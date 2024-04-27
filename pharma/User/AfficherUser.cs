using pharma.EFModel;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pharma.User
{
    public partial class AfficherUser : DevExpress.XtraEditors.XtraForm
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public AfficherUser()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            var users = gmp.Utilisateurs
                .Select(u => new
                {
                    u.UtilisateurID,
                    u.NomUtilisateur,
                    u.TypeUtilisateur,
                    u.DateInscription,
                }).ToArray();
            dgvUserList.DataSource = users;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvUserList.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvUserList.Columns.Count + 1; i++)
                {
                    MExcel.Cells[1, i] = dgvUserList.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvUserList.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvUserList.Columns.Count; j++)
                    {
                        MExcel.Cells[i + 2, j + 1] = dgvUserList.Rows[i].Cells[j].Value.ToString();
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
            int height = dgvUserList.Height;
            dgvUserList.Height = dgvUserList.RowCount * dgvUserList.RowTemplate.Height * 2;

            // Adjust the width of the DataGridView to match the width of the print page
            int width = printDocument1.DefaultPageSettings.Bounds.Width;
            dgvUserList.Width = width;

            // Create a bitmap to hold the DataGridView content
            bitmap = new Bitmap(width, dgvUserList.Height);
            dgvUserList.DrawToBitmap(bitmap, new Rectangle(0, 0, width, dgvUserList.Height));

            // Show the print preview dialog with the appropriate zoom level
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

            // Restore the original height of the DataGridView
            dgvUserList.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Calculate the horizontal offset required to center the image
            int horizontalOffset = (e.PageBounds.Width - dgvUserList.Width) / 2;

            // Draw the bitmap image on the printing page with the calculated offset
            e.Graphics.DrawImage(bitmap, horizontalOffset, 0);
        }
    }
}
