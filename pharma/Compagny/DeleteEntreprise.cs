using pharma.EFModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Compagny
{
    public partial class DeleteEntreprise : Form
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public DeleteEntreprise()
        {
            InitializeComponent();
        }

        private void DeleteEntreprise_Load(object sender, EventArgs e)
        {
            RemplirComboIdEntreprise();
            RemplirComboNomEntreprise();
        }

        private void RemplirComboIdEntreprise()
        {
            var entrepriseID = gmp.Entreprise.Select(c => c.EntrepriseID).ToList();
            cmbIdEse.DataSource = entrepriseID;
            cmbIdEse.SelectedIndex = -1;
        }

        private void RemplirComboNomEntreprise()
        {
            var entrepriseNom = gmp.Entreprise.Select(c => c.Nom).Distinct().ToList();
            cmbNomEse.DataSource = entrepriseNom;
            cmbNomEse.SelectedIndex = -1;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (cmbIdEse.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette Entreprise ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedEntrepriseId = (int)cmbIdEse.SelectedItem;
                    var entrepriseToDelete = gmp.Client.FirstOrDefault(c => c.ClientID == selectedEntrepriseId);

                    if (entrepriseToDelete != null)
                    {
                        gmp.Client.Remove(entrepriseToDelete);
                        gmp.SaveChanges();
                        MessageBox.Show("L'entreprise a été supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RemplirComboIdEntreprise();
                        RemplirComboNomEntreprise();
                    }
                    else
                    {
                        MessageBox.Show("L'entreprise sélectionnée n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entreprise à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNomEse_TextChanged(object sender, EventArgs e)
        {
            if (cmbNomEse.SelectedItem != null)
            {
                string selectedNom = cmbNomEse.SelectedItem.ToString();

                var entrepriseID = gmp.Entreprise
                                   .Where(c => c.Nom == selectedNom)
                                   .Select(c => c.EntrepriseID)
                                   .ToList();

                cmbIdEse.DataSource = entrepriseID;
            }
            else
            {
                cmbIdEse.DataSource = null;
            }
        }

        private void cmbIdEse_TextChanged(object sender, EventArgs e)
        {
            if (cmbIdEse.SelectedItem != null)
            {
                int selectedEntrepriseId = (int)cmbIdEse.SelectedItem;

                var selectedEntreprise = gmp.Entreprise.FirstOrDefault(c => c.EntrepriseID == selectedEntrepriseId);

                if (selectedEntreprise != null)
                {
                    lblNomEse.Text = selectedEntreprise.Nom;
                    lblAdresseEse.Text = selectedEntreprise.Adresse;
                    lblPersonneContacteEse.Text = selectedEntreprise.PersonneContact;
                    lblContatctEse.Text = selectedEntreprise.CoordonneesContact;
                }
                else
                {
                    lblNomEse.Text = "";
                    lblAdresseEse.Text = "";
                    lblPersonneContacteEse.Text = "";
                    lblContatctEse.Text = "";
                }
            }
            else
            {
                lblNomEse.Text = "";
                lblAdresseEse.Text = "";
                lblPersonneContacteEse.Text = "";
                lblContatctEse.Text = "";
            }
        }
    }
}
