using pharma.EFModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace pharma.User
{
    public partial class AddUser : DevExpress.XtraEditors.XtraForm
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            ChargerComboType();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblUser.Text = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string maskedPassword = new string('*', txtPassword.Text.Length);
            lblPas.Text = maskedPassword;

        }

        private void cmbTypeUser_TextChanged(object sender, EventArgs e)
        {
            lbltype.Text = cmbTypeUser.Text;
        }

        private void ChargerComboType()
        {
            cmbTypeUser.Items.Add("Vendeur");
            cmbTypeUser.Items.Add("Administrateur");
            cmbTypeUser.Items.Add("Pharmacien");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                    cmbTypeUser.SelectedIndex = -1;
                }
                else if (ctrl.HasChildren)
                {
                    ClearTextBoxes(ctrl); // Recursively clear textboxes within child controls
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si le nom d'utilisateur existe déjà
                if (gmp.Utilisateurs.Any(u => u.NomUtilisateur == txtUsername.Text))
                {
                    MessageBox.Show("Le nom d'utilisateur existe déjà. Veuillez choisir un autre nom d'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sortie de la méthode sans ajouter l'utilisateur
                }

                // Ajouter l'utilisateur si le nom d'utilisateur n'existe pas encore
                Utilisateurs utilisateurs = new Utilisateurs()
                {
                    NomUtilisateur = txtUsername.Text,
                    MotDePasse = txtPassword.Text,
                    TypeUtilisateur = cmbTypeUser.Text,
                    DateInscription = DateTime.Now
                };

                gmp.Utilisateurs.Add(utilisateurs);
                gmp.SaveChanges();
                MessageBox.Show("L'utilisateur a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout de l'utilisateur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
