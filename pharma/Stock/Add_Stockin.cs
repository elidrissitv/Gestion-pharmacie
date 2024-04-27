using pharma.EFModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Stock
{
    public partial class Add_Stockin : Form
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public Add_Stockin()
        {
            InitializeComponent();
        }

        private void Add_Stock_Load(object sender, EventArgs e)
        {
            LoadEntreprises();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomArticle_TextChanged(object sender, EventArgs e)
        {
            lblNom.Text = txtNomArticle.Text;
        }

        private void txtArticleDetail_TextChanged(object sender, EventArgs e)
        {
            lblArticleDetail.Text = txtArticleDetail.Text;
        }

        private void txtPrixUnitaire_TextChanged(object sender, EventArgs e)
        {
            lblPrix.Text = txtPrixUnitaire.Text;
        }

        private void nudQuantite_ValueChanged(object sender, EventArgs e)
        {
            lblQuantite.Text = nudQuantite.Value.ToString();

        }

        private void cmbNomEse_TextChanged(object sender, EventArgs e)
        {
            lblNom.Text = cmbNomEse.Text;
        }

        private void txtLieu_TextChanged(object sender, EventArgs e)
        {
            lblLieu.Text = txtLieu.Text;
        }

        private void dtpExp_TextChanged(object sender, EventArgs e)
        {
            lblDateExp.Text = dtpExp.Text;
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (ctrl.HasChildren)
                {
                    ClearTextBoxes(ctrl); // Recursively clear textboxes within child controls
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private void LoadEntreprises()
        {
            // Récupérer toutes les entreprises depuis la base de données
            var entreprises = gmp.Entreprise.ToList();

            // Ajouter chaque entreprise au ComboBox
            foreach (var entreprise in entreprises)
            {
                cmbNomEse.Items.Add(entreprise.Nom);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer l'ID de l'entreprise sélectionnée dans le ComboBox
                int entrepriseID = gmp.Entreprise
                    .Where(entreprise => entreprise.Nom == cmbNomEse.Text)
                    .Select(entreprise => entreprise.EntrepriseID)
                    .FirstOrDefault();

                // Créer un nouvel objet StockIn avec les données saisies
                StockIn stockin = new StockIn()
                {
                    NomArticle = txtNomArticle.Text,
                    Description = txtArticleDetail.Text,
                    PrixUnitaire = Convert.ToDecimal(txtPrixUnitaire.Text),
                    QuantiteEntree = (int)nudQuantite.Value,
                    EntrepriseID = entrepriseID, // Assigner l'ID de l'entreprise
                    LieuEntree = txtLieu.Text,
                    DateExpiration = dtpExp.Value,
                    DateEntree = DateTime.Now,
                };

                // Ajouter le StockIn à la base de données et sauvegarder les modifications
                gmp.StockIn.Add(stockin);
                gmp.SaveChanges();

                // Calculer le prix unitaire en fonction des règles spécifiées
                decimal prixUnitaire;
                if (stockin.PrixUnitaire >= 1 && stockin.PrixUnitaire < 20)
                {
                    prixUnitaire = (decimal)(stockin.PrixUnitaire * 1.2m); // Augmenter de 20%
                }
                else if (stockin.PrixUnitaire >= 20 && stockin.PrixUnitaire < 100)
                {
                    prixUnitaire = (decimal)stockin.PrixUnitaire * 1.3m; // Augmenter de 30%
                }
                else if (stockin.PrixUnitaire >= 100 && stockin.PrixUnitaire < 500)
                {
                    prixUnitaire = (decimal)stockin.PrixUnitaire * 1.35m; // Augmenter de 35%
                }
                else
                {
                    prixUnitaire = (decimal)stockin.PrixUnitaire * 1.4m; // Augmenter de 40%
                }

                // Créer un nouvel objet Stock avec les données calculées et récupérées
                pharma.EFModel.Stock stock = new pharma.EFModel.Stock() // Changer le nom de l'objet pour éviter les conflits
                {
                    NomArticle = stockin.NomArticle,
                    Description = stockin.Description,
                    QuantiteTotale = stockin.QuantiteEntree,
                    QuantiteVendue = 0,
                    QuantiteDisponible = stockin.QuantiteEntree,
                    PrixTotal = stockin.QuantiteEntree * prixUnitaire,
                    PrixUnitaire = prixUnitaire,
                    DateEntree = DateTime.Now,
                };

                // Ajouter le Stock à la base de données et sauvegarder les modifications
                gmp.Stock.Add(stock);
                gmp.SaveChanges();

                MessageBox.Show("Le stock a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout du stock : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtpExp_ValueChanged(object sender, EventArgs e)
        {
            lblDateExp.Text = dtpExp.Value.ToString("yyyy-MM-dd");
        }
    }
}
