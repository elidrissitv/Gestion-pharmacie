using pharma.EFModel;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Reports
{
    public partial class VenteRapport : Form
    {
        private GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();

        public VenteRapport()
        {
            InitializeComponent();
            ChargerComboBoxClients();
            ChargerComboBoxArticles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChargerComboBoxClients()
        {
            var clients = gmp.Client
                .Select(c => c.Nom)
                .Distinct()
                .ToList();
            cmbNomClient.DataSource = clients;
        }

        private void ChargerComboBoxArticles()
        {
            var articles = gmp.Vente
                .Select(v => v.NomArticle)
                .Distinct()
                .ToList();
            cmbNomArticle.DataSource = articles;
        }

        private void rechercherEse_Click(object sender, EventArgs e)
        {
            string nomClient = cmbNomClient.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(nomClient))
            {
                var ventesData = gmp.Vente
                    .Where(v => v.Client.Nom.Contains(nomClient))
                    .Select(v => new
                    {
                        v.Client.Nom,
                        v.NomArticle,
                        v.PrixUnitaire,
                        v.QuantiteVendue,
                        v.PrixTotal,
                        v.DateTransaction
                    })
                    .ToList();

                dgVente.DataSource = ventesData;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client pour effectuer la recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rechercherArticle_Click(object sender, EventArgs e)
        {
            string nomArticle = cmbNomArticle.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(nomArticle))
            {
                var ventesData = gmp.Vente
                    .Where(v => v.NomArticle.Contains(nomArticle))
                    .Select(v => new
                    {
                        v.Client.Nom,
                        v.NomArticle,
                        v.PrixUnitaire,
                        v.QuantiteVendue,
                        v.PrixTotal,
                        v.DateTransaction
                    })
                    .ToList();

                dgVente.DataSource = ventesData;
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
            int height = dgVente.Height;
            dgVente.Height = dgVente.RowCount * dgVente.RowTemplate.Height * 2;

            // Adjust the width of the DataGridView to match the width of the print page
            int width = printDocument1.DefaultPageSettings.Bounds.Width;
            dgVente.Width = width;

            // Create a bitmap to hold the DataGridView content
            bitmap = new Bitmap(width, dgVente.Height);
            dgVente.DrawToBitmap(bitmap, new Rectangle(0, 0, width, dgVente.Height));

            // Show the print preview dialog with the appropriate zoom level
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

            // Restore the original height of the DataGridView
            dgVente.Height = height;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgVente != null && dgVente.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgVente.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = dgVente.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgVente.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgVente.Columns.Count; j++)
                        {
                            MExcel.Cells[i + 2, j + 1] = dgVente.Rows[i].Cells[j].Value.ToString();
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
            int horizontalOffset = (e.PageBounds.Width - dgVente.Width) / 2;

            // Draw the bitmap image on the printing page with the calculated offset
            e.Graphics.DrawImage(bitmap, horizontalOffset, 0);
        }
    }
}
