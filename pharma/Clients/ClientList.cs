using pharma.EFModel;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Clients
{
    public partial class ClientList : Form
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientList_Load(object sender, EventArgs e)
        {
            LoadClientData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadClientData()
        {
            var clients = gmp.Client
                .Select(u => new
                {
                    u.ClientID,
                    u.Nom,
                    u.Prenom,
                    u.Telephone,
                    u.Adresse,
                    u.Ville,
                }).ToArray();
            dgvListClient.DataSource = clients;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvListClient.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvListClient.Columns.Count + 1; i++)
                {
                    MExcel.Cells[1, i] = dgvListClient.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvListClient.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvListClient.Columns.Count; j++)
                    {
                        MExcel.Cells[i + 2, j + 1] = dgvListClient.Rows[i].Cells[j].Value.ToString();
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

        private Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Increase the height of the DataGridView to fit all rows
            int height = dgvListClient.Height;
            dgvListClient.Height = dgvListClient.RowCount * dgvListClient.RowTemplate.Height * 2;

            // Adjust the width of the DataGridView to match the width of the print page
            int width = printDocument1.DefaultPageSettings.Bounds.Width;
            dgvListClient.Width = width;

            // Create a bitmap to hold the DataGridView content
            bitmap = new Bitmap(width, dgvListClient.Height);
            dgvListClient.DrawToBitmap(bitmap, new Rectangle(0, 0, width, dgvListClient.Height));

            // Show the print preview dialog with the appropriate zoom level
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

            // Restore the original height of the DataGridView
            dgvListClient.Height = height;
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Calculate the horizontal offset required to center the image
            int horizontalOffset = (e.PageBounds.Width - dgvListClient.Width) / 2;

            // Draw the bitmap image on the printing page with the calculated offset
            e.Graphics.DrawImage(bitmap, horizontalOffset, 0);
        }
    }
}
