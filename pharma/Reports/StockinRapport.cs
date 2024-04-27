using pharma.EFModel;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Reports
{
    public partial class StockinRapport : Form
    {
        private GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();

        public StockinRapport()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {
            ChargerComboBoxEntreprises();
            ChargerComboBoxArticles();
        }

        private void ChargerComboBoxEntreprises()
        {
            var entreprises = gmp.Entreprise.Select(ent => ent.Nom).Distinct().ToList();
            cmbNomEse.DataSource = entreprises;
        }

        private void ChargerComboBoxArticles()
        {
            var articles = gmp.StockIn.Select(art => art.NomArticle).Distinct().ToList();
            cmbNomArticle.DataSource = articles;
        }

        private void rechercherEse_Click(object sender, EventArgs e)
        {
            string companyName = cmbNomEse.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(companyName))
            {
                var stockInData = gmp.StockIn
                    .Where(s => s.Entreprise.Nom.Contains(companyName))
                    .Select(s => new
                    {
                        s.NomArticle,
                        s.QuantiteEntree,
                        s.PrixUnitaire,
                        s.DateExpiration,
                        s.LieuEntree
                    })
                    .ToList();
                dgvStockin.DataSource = stockInData;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entreprise pour effectuer la recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void rechercherArticle_Click(object sender, EventArgs e)
        {
            string articleName = cmbNomArticle.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(articleName))
            {
                var stockInData = gmp.StockIn
                    .Where(s => s.Stock.NomArticle.Contains(articleName))
                    .Select(s => new
                    {
                        s.NomArticle,
                        s.QuantiteEntree,
                        s.PrixUnitaire,
                        s.DateExpiration,
                        s.LieuEntree
                    })
                    .ToList();
                dgvStockin.DataSource = stockInData;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un article pour effectuer la recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private Bitmap bitmap;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Increase the height of the DataGridView to fit all rows
            int height = dgvStockin.Height;
            dgvStockin.Height = dgvStockin.RowCount * dgvStockin.RowTemplate.Height * 2;

            // Adjust the width of the DataGridView to match the width of the print page
            int width = printDocument1.DefaultPageSettings.Bounds.Width;
            dgvStockin.Width = width;

            // Create a bitmap to hold the DataGridView content
            bitmap = new Bitmap(width, dgvStockin.Height);
            dgvStockin.DrawToBitmap(bitmap, new Rectangle(0, 0, width, dgvStockin.Height));

            // Show the print preview dialog with the appropriate zoom level
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

            // Restore the original height of the DataGridView
            dgvStockin.Height = height;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStockin != null && dgvStockin.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvStockin.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = dgvStockin.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvStockin.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvStockin.Columns.Count; j++)
                        {
                            MExcel.Cells[i + 2, j + 1] = dgvStockin.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    MExcel.Columns.AutoFit();
                    MExcel.Rows.AutoFit();
                    MExcel.Columns.Font.Size = 12;
                    MExcel.Visible = true;
                }
                else
                {
                    MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving data to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Calculate the horizontal offset required to center the image
            int horizontalOffset = (e.PageBounds.Width - dgvStockin.Width) / 2;

            // Draw the bitmap image on the printing page with the calculated offset
            e.Graphics.DrawImage(bitmap, horizontalOffset, 0);
        }
    }
}
