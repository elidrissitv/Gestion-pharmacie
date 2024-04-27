using pharma.EFModel;
using System.Linq;
using System.Windows.Forms;

namespace pharma.User
{
    public partial class DeleteUser : DevExpress.XtraEditors.XtraForm
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, System.EventArgs e)
        {
            RemplirComboIdUser();
            RemplirComboNomUser();
        }

        private void RemplirComboIdUser()
        {
            var userID = gmp.Utilisateurs.Select(c => c.UtilisateurID).ToList();
            cmbIdUser.DataSource = userID;
            cmbIdUser.SelectedIndex = -1;
        }

        private void RemplirComboNomUser()
        {
            // Récupérer tous les noms de clients distincts
            var userNames = gmp.Utilisateurs.Select(c => c.NomUtilisateur).Distinct().ToList();

            // Remplir le ComboBox des noms de clients avec les noms distincts
            cmbNomUser.DataSource = userNames;
            cmbNomUser.SelectedIndex = -1;
        }

        private void cmbNomUser_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Vérifier si un élément est sélectionné dans le ComboBox
            if (cmbNomUser.SelectedItem != null)
            {
                // Récupérer le nom du client sélectionné dans le ComboBox
                string selectedNom = cmbNomUser.SelectedItem.ToString();

                // Filtrer les ID des clients ayant le même nom que celui sélectionné
                var clientIDs = gmp.Utilisateurs
                                   .Where(c => c.NomUtilisateur == selectedNom)
                                   .Select(c => c.UtilisateurID)
                                   .ToList();

                // Remplir le ComboBox des ID du client avec les ID filtrés
                cmbIdUser.DataSource = clientIDs;
            }
            else
            {
                // Effacer le ComboBox des ID du client s'il n'y a pas de sélection
                cmbIdUser.DataSource = null;
            }
        }

        private void cmbIdUser_TextChanged(object sender, System.EventArgs e)
        {
            // Vérifier si un élément est sélectionné dans le ComboBox des ID du client
            if (cmbIdUser.SelectedItem != null)
            {
                // Récupérer l'ID du client sélectionné dans le ComboBox
                int selectedUserId = (int)cmbIdUser.SelectedItem;

                // Récupérer les informations du client correspondant à cet ID
                var selectedUser = gmp.Utilisateurs.FirstOrDefault(c => c.UtilisateurID == selectedUserId);

                // Vérifier si le client a été trouvé
                if (selectedUser != null)
                {
                    // Afficher les informations du client dans les labels
                    lblnomutilisateur.Text = selectedUser.NomUtilisateur;
                    string pass = selectedUser.MotDePasse;
                    lblpassword.Text = new string('*', pass.Length);
                    lbltype.Text = selectedUser.TypeUtilisateur;
                }
                else
                {
                    // Effacer les labels si aucun client n'est trouvé
                    lblnomutilisateur.Text = "";
                    lblpassword.Text = "";
                    lbltype.Text = "";
                }
            }
            else
            {
                // Effacer les labels si aucun client n'est trouvé
                lblnomutilisateur.Text = "";
                lblpassword.Text = "";
                lbltype.Text = "";
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            // Vérifier si un client est sélectionné
            if (cmbIdUser.SelectedItem != null)
            {
                // Demander à l'utilisateur de confirmer la suppression
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur confirme la suppression
                if (result == DialogResult.Yes)
                {
                    // Récupérer l'ID du client sélectionné
                    int selectedUserId = (int)cmbIdUser.SelectedItem;

                    // Récupérer le client correspondant à cet ID
                    var userToDelete = gmp.Utilisateurs.FirstOrDefault(c => c.UtilisateurID == selectedUserId);

                    // Vérifier si le client existe
                    if (userToDelete != null)
                    {
                        // Supprimer le client de la base de données
                        gmp.Utilisateurs.Remove(userToDelete);
                        gmp.SaveChanges();

                        // Afficher un message de succès
                        MessageBox.Show("L'utilisateur a été supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Rafraîchir les ComboBox après la suppression
                        RemplirComboIdUser();
                        RemplirComboNomUser();
                    }
                    else
                    {
                        // Afficher un message d'erreur si le client n'est pas trouvé
                        MessageBox.Show("L'utilisateur sélectionné n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
