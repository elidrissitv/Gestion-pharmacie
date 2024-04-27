using pharma.EFModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Stock
{
    public partial class UpdateStock : DevExpress.XtraEditors.XtraForm
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, System.EventArgs e)
        {
            RemplirComboNomArticle();
            RemplirComboIdArticle();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void RemplirComboNomArticle()
        {
            var stockinNom = gmp.StockIn.Select(c => c.NomArticle).Distinct().ToList();
            cmbNomArticle.DataSource = stockinNom;
            cmbNomArticle.SelectedIndex = -1;
        }

        private void RemplirComboIdArticle()
        {
            var stockinId = gmp.StockIn.Select(c => c.StockInID).ToList();
            cmbIdArticle.DataSource = stockinId;
            cmbIdArticle.SelectedIndex = -1;
        }

        private void cmbNomArticle_TextChanged(object sender, System.EventArgs e)
        {
            if (cmbNomArticle.SelectedItem != null)
            {
                string selectedNom = cmbNomArticle.SelectedItem.ToString();

                var articleIDs = gmp.StockIn
                                   .Where(c => c.NomArticle == selectedNom)
                                   .Select(c => c.StockInID)
                                   .ToList();

                cmbIdArticle.DataSource = articleIDs;
            }
            else
            {
                cmbIdArticle.DataSource = null;
            }
        }

        private void cmbIdArticle_TextChanged(object sender, System.EventArgs e)
        {
            if (cmbIdArticle.SelectedItem != null)
            {
                int selectedStockinId = (int)cmbIdArticle.SelectedItem;

                var selectedArticle = gmp.StockIn.FirstOrDefault(c => c.StockID == selectedStockinId);

                if (selectedArticle != null)
                {
                    lblNomArticle.Text = selectedArticle.NomArticle;
                    lblArticleDetail.Text = selectedArticle.Description;
                    lblPrixUnitaire.Text = selectedArticle.PrixUnitaire.ToString();
                    lblQuantite.Text = selectedArticle.QuantiteEntree.ToString();
                    lblLieu.Text = selectedArticle.LieuEntree;
                    lblDateExp.Text = selectedArticle.DateExpiration.ToString();
                }
                else
                {
                    lblNomArticle.Text = "";
                    lblArticleDetail.Text = "";
                    lblPrixUnitaire.Text = "";
                    lblQuantite.Text = "";
                    lblLieu.Text = "";
                    lblDateExp.Text = "";
                }
            }
            else
            {
                lblNomArticle.Text = "";
                lblArticleDetail.Text = "";
                lblPrixUnitaire.Text = "";
                lblQuantite.Text = "";
                lblLieu.Text = "";
                lblDateExp.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (cmbIdArticle.SelectedItem != null)
                {
                    int selectedStockinId = (int)cmbIdArticle.SelectedItem;
                    var selectedStockin = gmp.StockIn.FirstOrDefault(c => c.StockInID == selectedStockinId); // Correction ici

                    if (selectedStockin != null)
                    {
                        // Mettre à jour les quantités totales et disponibles dans la table Stock
                        var stock = gmp.Stock.FirstOrDefault(s => s.NomArticle == selectedStockin.NomArticle);

                        if (stock != null)
                        {
                            stock.QuantiteTotale = Convert.ToInt32(txtQuantiteTotale.Text); // Correction ici
                            stock.QuantiteDisponible = Convert.ToInt32(txtQuantiteDisponible.Text);

                            // Mettre à jour les enregistrements dans la base de données
                            gmp.SaveChanges();

                            MessageBox.Show("Les informations sur le stock ont été mises à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("L'article sélectionné n'existe pas dans la table Stock.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'article sélectionné n'existe pas dans la table StockIn.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un article.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la mise à jour des informations sur le stock : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
