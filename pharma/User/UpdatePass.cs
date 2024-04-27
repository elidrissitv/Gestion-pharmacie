using pharma.EFModel;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace pharma.User
{
    public partial class UpdatePass : DevExpress.XtraEditors.XtraForm
    {
        private Utilisateurs loggedInUser;
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();

        public UpdatePass(Utilisateurs user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void UpdatePass_Load(object sender, EventArgs e)
        {
            userLabel.Text = loggedInUser.NomUtilisateur;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNewPassword.Text) && !string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    if (txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        loggedInUser.MotDePasse = txtNewPassword.Text;
                        gmp.Entry(loggedInUser).State = EntityState.Modified; // Mark the entity as modified
                        gmp.SaveChanges(); // Save the changes to the database

                        MessageBox.Show("Mot de passes mis à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNewPassword.Text = txtConfirmPassword.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez saisir un nouveau mot de passe et le confirmer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la mise à jour du mot de passe : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNewPassword.Text = txtConfirmPassword.Text = string.Empty;
        }
    }
}