using pharma.EFModel;
using System;
using System.Windows.Forms;

namespace pharma.Login
{
    public partial class HelpForm : Form
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public HelpForm()
        {
            InitializeComponent();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomPrenom.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtTelephone.Text) ||
        string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ContacterNous contacterNous = new ContacterNous
            {
                NomPrenom = txtNomPrenom.Text,
                Email = txtEmail.Text,
                Telephone = txtTelephone.Text,
                Message = txtMessage.Text,
            };

            try
            {
                gmp.ContacterNous.Add(contacterNous);
                gmp.SaveChanges();
                MessageBox.Show("Votre message a été envoyé avec succès. Nous vous répondrons dans les plus brefs délais.", "Message envoyé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'envoi du message : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
