using pharma.EFModel;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pharma
{
    public partial class ViewStock : DevExpress.XtraEditors.XtraForm
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public ViewStock()
        {
            InitializeComponent();
        }

        private void ViewStock_Load(object sender, EventArgs e)
        {
            ChargerDgvList();
        }
        private void ChargerDgvList()
        {
            try
            {
                var stock = gmp.Stock
                .Select(u => new
                {
                    u.StockID,
                    u.NomArticle,
                    u.Description,
                    u.QuantiteTotale,
                    u.QuantiteVendue,
                    u.QuantiteDisponible,
                    u.PrixTotal,
                    u.PrixUnitaire,
                    u.DateEntree,
                }).ToArray();
                dgvStockList.DataSource = stock;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Increase the height of the DataGridView to fit all rows
            int height = dgvStockList.Height;
            dgvStockList.Height = dgvStockList.RowCount * dgvStockList.RowTemplate.Height * 2;

            // Adjust the width of the DataGridView to match the width of the print page
            int width = printDocument1.DefaultPageSettings.Bounds.Width;
            dgvStockList.Width = width;

            // Create a bitmap to hold the DataGridView content
            bitmap = new Bitmap(width, dgvStockList.Height);
            dgvStockList.DrawToBitmap(bitmap, new Rectangle(0, 0, width, dgvStockList.Height));

            // Show the print preview dialog with the appropriate zoom level
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

            // Restore the original height of the DataGridView
            dgvStockList.Height = height;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStockList != null && dgvStockList.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvStockList.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = dgvStockList.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvStockList.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvStockList.Columns.Count; j++)
                        {
                            MExcel.Cells[i + 2, j + 1] = dgvStockList.Rows[i].Cells[j].Value.ToString();
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
            int horizontalOffset = (e.PageBounds.Width - dgvStockList.Width) / 2;

            // Draw the bitmap image on the printing page with the calculated offset
            e.Graphics.DrawImage(bitmap, horizontalOffset, 0);
        }
    }
}
