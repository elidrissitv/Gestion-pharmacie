using pharma.EFModel;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Reports
{
    public partial class StockRapport : Form
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public StockRapport()
        {
            InitializeComponent();
            ChargerComboBoxArticles();
        }

        private void ChargerComboBoxArticles()
        {
            var articles = gmp.Stock
                .Select(s => s.NomArticle)
                .Distinct()
                .ToList();
            cmbNomArticle.DataSource = articles;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string articleName = cmbNomArticle.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(articleName))
            {
                var stockData = gmp.Stock
                    .Where(s => s.NomArticle.Contains(articleName))
                    .Select(s => new
                    {
                        s.NomArticle,
                        s.Description,
                        s.QuantiteTotale,
                        s.QuantiteVendue,
                        s.QuantiteDisponible,
                        s.PrixTotal,
                        s.PrixUnitaire,
                        s.DateEntree
                    })
                    .ToList();
                dgvStock.DataSource = stockData;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un article pour effectuer la recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Increase the height of the DataGridView to fit all rows
            int height = dgvStock.Height;
            dgvStock.Height = dgvStock.RowCount * dgvStock.RowTemplate.Height * 2;

            // Adjust the width of the DataGridView to match the width of the print page
            int width = printDocument1.DefaultPageSettings.Bounds.Width;
            dgvStock.Width = width;

            // Create a bitmap to hold the DataGridView content
            bitmap = new Bitmap(width, dgvStock.Height);
            dgvStock.DrawToBitmap(bitmap, new Rectangle(0, 0, width, dgvStock.Height));

            // Show the print preview dialog with the appropriate zoom level
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

            // Restore the original height of the DataGridView
            dgvStock.Height = height;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStock != null && dgvStock.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvStock.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = dgvStock.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvStock.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvStock.Columns.Count; j++)
                        {
                            MExcel.Cells[i + 2, j + 1] = dgvStock.Rows[i].Cells[j].Value.ToString();
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
            int horizontalOffset = (e.PageBounds.Width - dgvStock.Width) / 2;

            // Draw the bitmap image on the printing page with the calculated offset
            e.Graphics.DrawImage(bitmap, horizontalOffset, 0);
        }
    }
}
