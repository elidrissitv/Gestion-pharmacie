using pharma.EFModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Login
{
    public partial class ModernLoginForm : DevExpress.XtraEditors.XtraForm
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public static Utilisateurs SelectedUtilisateur { get; set; }

        public ModernLoginForm()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;
            var utilisateurinfo = gmp.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == txtUser.Text);
            if (utilisateurinfo != null)
            {
                SelectedUtilisateur = utilisateurinfo;
                Form1 f1 = new Form1(SelectedUtilisateur);
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Le nom d'utilisateur ou le mot de passe est incorrect!\r\n", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void hidenButtton_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*'; // Hide password characters
                showenButton.BringToFront(); // Bring the hide button to the front
            }
        }

        private void showenButton_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0'; // Show password characters
                hidenButtton.BringToFront(); // Bring the show button to the front
                txtPassword.Text = txtPassword.Text; // Update the text to show the password
            }
        }
    }
}