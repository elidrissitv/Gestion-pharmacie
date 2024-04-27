using pharma.EFModel;
using System;
using System.Windows.Forms;

namespace pharma.Compagny
{
    public partial class AddEntreprise : Form
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public AddEntreprise()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
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

        private void btnAjouter_Click(object sender, System.EventArgs e)
        {
            try
            {
                Entreprise entreprise = new Entreprise()
                {
                    Nom = txtNom.Text,
                    Adresse = txtAdresse.Text,
                    PersonneContact = txtPersonneContact.Text,
                    CoordonneesContact = txtContact.Text
                };

                gmp.Entreprise.Add(entreprise);
                gmp.SaveChanges();
                MessageBox.Show("L'entreprise a été ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout de l'entreprise : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            nomese.Text = txtNom.Text;
        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {
            adresseese.Text = txtAdresse.Text;
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            contactese.Text = txtContact.Text;
        }

        private void txtPersonneContact_TextChanged(object sender, EventArgs e)
        {
            personnecontactese.Text = txtPersonneContact.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
