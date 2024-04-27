using pharma.EFModel;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace pharma.Sell
{
    public partial class Sellarea : DevExpress.XtraEditors.XtraForm
    {
        private GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();

        public Sellarea()
        {
            InitializeComponent();
            ChargerComboBoxClients();
            ChargerComboBoxArticles();
        }

        private void ChargerComboBoxClients()
        {
            var clients = gmp.Client
                .Select(c => c.Nom)
                .Distinct()
                .ToList();
            cmbNomClient.DataSource = clients;
        }

        private void ChargerComboBoxArticles()
        {
            var articles = gmp.Stock
                .Select(s => s.NomArticle)
                .Distinct()
                .ToList();
            cmbArticleAVendre.DataSource = articles;
        }

        private void cmbArticleAVendre_TextChanged(object sender, EventArgs e)
        {
            string selectedArticle = cmbArticleAVendre.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedArticle))
            {
                var selectedEntreprise = gmp.Vente.FirstOrDefault(c => c.NomArticle == selectedArticle);

                if (selectedEntreprise != null)
                {
                    lblNomArticle.Text = selectedEntreprise.NomArticle;
                    lblQuantite.Text = nudQuantite.Value.ToString();
                    lblPrixUnitaire.Text = selectedEntreprise.PrixUnitaire.ToString();
                }
                else
                {
                    lblNomArticle.Text = "";
                    lblQuantite.Text = "";
                    lblPrixUnitaire.Text = "";
                }
            }
            else
            {
                lblNomArticle.Text = "";
                lblQuantite.Text = "";
                lblPrixUnitaire.Text = "";
            }
        }

        private void cmbNomClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomArticle = cmbArticleAVendre.SelectedItem?.ToString();
            int quantite = (int)nudQuantite.Value;

            if (!string.IsNullOrEmpty(nomArticle) && quantite > 0)
            {
                // Ajouter la commande à la datagrid
                dgvCommande.Rows.Add(nomArticle, quantite);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un article et une quantité valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                // Get data from the form
                string selectedArticle = cmbArticleAVendre.SelectedItem?.ToString();
                int quantity = (int)nudQuantite.Value;

                // Get the client ID from the ComboBox
                int? clientID = cmbIdClient.SelectedItem as int?;

                // Check if the clientID is null
                if (clientID == null)
                {
                    MessageBox.Show("Veuillez sélectionner un client.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method early
                }

                // Check if the quantity exceeds the available quantity in stock
                var stockItem = gmp.Stock.FirstOrDefault(s => s.NomArticle == selectedArticle);

                if (stockItem != null && quantity > stockItem.QuantiteDisponible)
                {
                    MessageBox.Show("Quantité demandée supérieure à la quantité disponible en stock.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the unit price from the Stock table
                decimal unitPrice = (decimal)gmp.Stock
                    .Where(s => s.NomArticle == selectedArticle)
                    .Select(s => s.PrixUnitaire)
                    .FirstOrDefault();

                decimal totalPrice = quantity * unitPrice;

                // Call the stored procedure to insert data into the Vente table
                gmp.Database.ExecuteSqlCommand("InsertVente @ClientID, @NomArticle, @PrixUnitaire, @QuantiteVendue, @PrixTotal, @DateTransaction",
                    new SqlParameter("@ClientID", clientID.Value),
                    new SqlParameter("@NomArticle", selectedArticle),
                    new SqlParameter("@PrixUnitaire", unitPrice),
                    new SqlParameter("@QuantiteVendue", quantity),
                    new SqlParameter("@PrixTotal", totalPrice),
                    new SqlParameter("@DateTransaction", DateTime.Now));

                MessageBox.Show("La commande a été soumise avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, you can refresh the DataGridView or perform any other action needed after submitting the order.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la soumission de la commande : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Effacer la datagrid et réinitialiser les valeurs des combobox et du numericupdown
            dgvCommande.Rows.Clear();
            cmbNomClient.SelectedIndex = -1;
            cmbArticleAVendre.SelectedIndex = -1;
            nudQuantite.Value = 0;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            dgvCommande.Columns.Add("NomArticle", "Nom de l'article");
            dgvCommande.Columns.Add("QuantiteVendue", "Quantité vendue");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    lblNomCLient.Text = selectedClient.Nom;
                    lblPrenom.Text = selectedClient.Prenom;
                    lblTelephoneCLient.Text = selectedClient.Telephone;
                    lblAdresseClient.Text = selectedClient.Adresse;
                }
                else
                {
                    // Effacer les labels si aucun client n'est trouvé
                    lblNomCLient.Text = "";
                    lblPrenom.Text = "";
                    lblTelephoneCLient.Text = "";
                    lblAdresseClient.Text = "";
                }
            }
            else
            {
                lblNomCLient.Text = "";
                lblPrenom.Text = "";
                lblTelephoneCLient.Text = "";
                lblAdresseClient.Text = "";
            }
        }
    }
}