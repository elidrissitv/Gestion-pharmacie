using pharma.EFModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Stock
{
    public partial class DeleteStockin : DevExpress.XtraEditors.XtraForm
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public DeleteStockin()
        {
            InitializeComponent();
        }

        private void DeleteStock_Load(object sender, EventArgs e)
        {
            RemplirComboNomArticle();
            RemplirComboIdArticle();
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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbIdArticle_TextChanged(object sender, EventArgs e)
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

        private void cmbNomArticle_TextChanged(object sender, EventArgs e)
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

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (cmbIdArticle.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette Entreprise ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedStockInId = (int)cmbIdArticle.SelectedItem;
                    var stockInToDelete = gmp.StockIn.FirstOrDefault(c => c.StockInID == selectedStockInId);

                    if (stockInToDelete != null)
                    {
                        gmp.StockIn.Remove(stockInToDelete);
                        gmp.SaveChanges();
                        MessageBox.Show("Le Stock d'entrée a été supprime avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RemplirComboIdArticle();
                        RemplirComboNomArticle();
                    }
                    else
                    {
                        MessageBox.Show("Le Stock d'entrée sélectionné n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un Stock d'entrée à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
