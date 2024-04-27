using pharma.EFModel;
using System;
using System.Windows.Forms;

namespace pharma.Clients
{
    public partial class AddCli : DevExpress.XtraEditors.XtraForm
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public AddCli()
        {
            InitializeComponent();
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
                }
                else if (ctrl.HasChildren)
                {
                    ClearTextBoxes(ctrl); // Recursively clear textboxes within child controls
                }
            }
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client()
                {
                    Nom = txtNom.Text,
                    Prenom = txtPrenom.Text,
                    Telephone = txtTelephone.Text,
                    Adresse = txtAdresse.Text,
                    Ville = txtVille.Text
                };

                gmp.Client.Add(client);
                gmp.SaveChanges();
                MessageBox.Show("Le client a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCli_Load(object sender, EventArgs e)
        {
        }

        //Remplir les Labels:
        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            lblnom.Text = txtNom.Text;
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            lblprenom.Text = txtPrenom.Text;
        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {
            lbltelephone.Text = txtTelephone.Text;
        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {
            lbladresse.Text = txtAdresse.Text;
        }

        private void txtVille_TextChanged(object sender, EventArgs e)
        {
            lblville.Text = txtVille.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
