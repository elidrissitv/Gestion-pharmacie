using pharma.EFModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Clients
{
    public partial class DeleteClient : Form
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public DeleteClient()
        {
            InitializeComponent();
        }
        private void DeleteClient_Load(object sender, EventArgs e)
        {
            RemplirCOmboNomClient();
            RemplirCOmboIdClient();
        }
        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemplirCOmboIdClient()
        {
            var clientID = gmp.Client.Select(c => c.ClientID).ToList();
            cmbIdClient.DataSource = clientID;
            cmbIdClient.SelectedIndex = -1;
        }

        private void RemplirCOmboNomClient()
        {
            // Récupérer tous les noms de clients distincts
            var clientNames = gmp.Client.Select(c => c.Nom).Distinct().ToList();

            // Remplir le ComboBox des noms de clients avec les noms distincts
            cmbNomClient.DataSource = clientNames;
            cmbNomClient.SelectedIndex = -1;
        }

        private void cmbNomClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifier si un élément est sélectionné dans le ComboBox
            if (cmbNomClient.SelectedItem != null)
            {
                // Récupérer le nom du client sélectionné dans le ComboBox
                string selectedNom = cmbNomClient.SelectedItem.ToString();

                // Filtrer les ID des clients ayant le même nom que celui sélectionné
                var clientIDs = gmp.Client
                                   .Where(c => c.Nom == selectedNom)
                                   .Select(c => c.ClientID)
                                   .ToList();

                // Remplir le ComboBox des ID du client avec les ID filtrés
                cmbIdClient.DataSource = clientIDs;
            }
            else
            {
                // Effacer le ComboBox des ID du client s'il n'y a pas de sélection
                cmbIdClient.DataSource = null;
            }
        }

        private void cmbIdClient_TextChanged(object sender, EventArgs e)
        {
            // Vérifier si un élément est sélectionné dans le ComboBox des ID du client
            if (cmbIdClient.SelectedItem != null)
            {
                // Récupérer l'ID du client sélectionné dans le ComboBox
                int selectedClientId = (int)cmbIdClient.SelectedItem;

                // Récupérer les informations du client correspondant à cet ID
                var selectedClient = gmp.Client.FirstOrDefault(c => c.ClientID == selectedClientId);

                // Vérifier si le client a été trouvé
                if (selectedClient != null)
                {
                    // Afficher les informations du client dans les labels
                    lblnom.Text = selectedClient.Nom;
                    lblprenom.Text = selectedClient.Prenom;
                    lbltelephone.Text = selectedClient.Telephone;
                    lbladresse.Text = selectedClient.Adresse;
                    lblville.Text = selectedClient.Ville;
                }
                else
                {
                    // Effacer les labels si aucun client n'est trouvé
                    lblnom.Text = "";
                    lblprenom.Text = "";
                    lbltelephone.Text = "";
                    lbladresse.Text = "";
                    lblville.Text = "";
                }
            }
            else
            {
                // Effacer les labels si aucun client n'est trouvé
                lblnom.Text = "";
                lblprenom.Text = "";
                lbltelephone.Text = "";
                lbladresse.Text = "";
                lblville.Text = "";
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Vérifier si un client est sélectionné
            if (cmbIdClient.SelectedItem != null)
            {
                // Demander à l'utilisateur de confirmer la suppression
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur confirme la suppression
                if (result == DialogResult.Yes)
                {
                    // Récupérer l'ID du client sélectionné
                    int selectedClientId = (int)cmbIdClient.SelectedItem;

                    // Récupérer le client correspondant à cet ID
                    var clientToDelete = gmp.Client.FirstOrDefault(c => c.ClientID == selectedClientId);

                    // Vérifier si le client existe
                    if (clientToDelete != null)
                    {
                        // Supprimer le client de la base de données
                        gmp.Client.Remove(clientToDelete);
                        gmp.SaveChanges();

                        // Afficher un message de succès
                        MessageBox.Show("Le client a été supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Rafraîchir les ComboBox après la suppression
                        RemplirCOmboNomClient();
                        RemplirCOmboIdClient();
                    }
                    else
                    {
                        // Afficher un message d'erreur si le client n'est pas trouvé
                        MessageBox.Show("Le client sélectionné n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Afficher un message d'erreur si aucun client n'est sélectionné
                MessageBox.Show("Veuillez sélectionner un client à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
