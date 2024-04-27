using pharma.EFModel;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Compagny
{
    public partial class AfficherEntreprises : Form
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public AfficherEntreprises()
        {
            InitializeComponent();
        }

        private void AfficherEntreprises_Load(object sender, EventArgs e)
        {
            ChargerDgvList();
        }

        private void ChargerDgvList()
        {
            try
            {
                var entreprises = gmp.Entreprise
                .Select(u => new
                {
                    u.EntrepriseID,
                    u.Nom,
                    u.PersonneContact,
                    u.Adresse,
                    u.CoordonneesContact,
                    u.DateEntree,
                }).ToArray();
                dgvListeEntreprise.DataSource = entreprises;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Bitmap bitmap;

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            // Increase the height of the DataGridView to fit all rows
            int height = dgvListeEntreprise.Height;
            dgvListeEntreprise.Height = dgvListeEntreprise.RowCount * dgvListeEntreprise.RowTemplate.Height * 2;

            // Adjust the width of the DataGridView to match the width of the print page
            int width = printDocument1.DefaultPageSettings.Bounds.Width;
            dgvListeEntreprise.Width = width;

            // Create a bitmap to hold the DataGridView content
            bitmap = new Bitmap(width, dgvListeEntreprise.Height);
            dgvListeEntreprise.DrawToBitmap(bitmap, new Rectangle(0, 0, width, dgvListeEntreprise.Height));

            // Show the print preview dialog with the appropriate zoom level
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

            // Restore the original height of the DataGridView
            dgvListeEntreprise.Height = height;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (dgvListeEntreprise != null && dgvListeEntreprise.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvListeEntreprise.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = dgvListeEntreprise.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvListeEntreprise.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvListeEntreprise.Columns.Count; j++)
                        {
                            MExcel.Cells[i + 2, j + 1] = dgvListeEntreprise.Rows[i].Cells[j].Value.ToString();
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
            int horizontalOffset = (e.PageBounds.Width - dgvListeEntreprise.Width) / 2;

            // Draw the bitmap image on the printing page with the calculated offset
            e.Graphics.DrawImage(bitmap, horizontalOffset, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
