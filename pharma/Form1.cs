using pharma.Clients;
using pharma.Compagny;
using pharma.EFModel;
using pharma.Login;
using pharma.Reports;
using pharma.Sell;
using pharma.Stock;
using pharma.User;
using System;
using System.Windows.Forms;

namespace pharma
{
    public partial class Form1 : Form
    {
        GestionMagasinPharmacieEntities5 gmp = new GestionMagasinPharmacieEntities5();
        private Utilisateurs SelectedUtilisateur;
        private DashboardApp.Models.Dashboard dashboardAppInstance;

        //private Dashboard model;
        public Form1(Utilisateurs SelectedUtilisateur)
        {
            InitializeComponent();
            hideSubMenu();
            this.SelectedUtilisateur = SelectedUtilisateur;
            dashboardAppInstance = new DashboardApp.Models.Dashboard(gmp); // Instantiate the Dashboard class
            LoadData(); // Call LoadData method to load initial data
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserLabel();
        }

        private void LoadUserLabel()
        {
            if (SelectedUtilisateur != null)
            {
                userLabel.Text = SelectedUtilisateur.NomUtilisateur;
            }
        }

        private void hideSubMenu()
        {
            panelStockSubMenu.Visible = false;
            panelEntrepriseSubMenu.Visible = false;
            panelClientsSubMenu.Visible = false;
            panelRapportSubMenu.Visible = false;
            panelUtilisateurSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnAccueil_Click(object sender, System.EventArgs e)
        {
            panelSideMenu.Visible = false;
            openChildForm(new Form1(SelectedUtilisateur));
        }

        private void btnStock_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelStockSubMenu);
        }

        private void btnEntreprise_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelEntrepriseSubMenu);
        }

        private void btnClients_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelClientsSubMenu);
        }

        private void btnRapport_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelRapportSubMenu);
        }

        private void btnGererUser_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelUtilisateurSubMenu);
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new HelpForm());
        }

        private void btnStockNouveau_Click(object sender, System.EventArgs e)
        {
            openChildForm(new Add_Stockin());
            hideSubMenu();
        }

        private void btnStockMiseajour_Click(object sender, System.EventArgs e)
        {
            openChildForm(new UpdateStock());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnStockSupprimer_Click(object sender, System.EventArgs e)
        {
            openChildForm(new DeleteStockin());
            hideSubMenu();
        }

        private void btnStockRapport_Click(object sender, System.EventArgs e)
        {
            openChildForm(new ViewStock());
            hideSubMenu();
        }

        private void btnCliAdd_Click(object sender, System.EventArgs e)
        {
            openChildForm(new AddCli());
            hideSubMenu();
        }

        private void btnCliSuprimmer_Click(object sender, System.EventArgs e)
        {
            openChildForm(new DeleteClient());
            hideSubMenu();
        }

        private void btnCliAfficher_Click(object sender, System.EventArgs e)
        {
            openChildForm(new ClientList());
            hideSubMenu();
        }

        private void btnVente_Click(object sender, System.EventArgs e)
        {
            openChildForm(new Sellarea());
            hideSubMenu();
        }

        private void btnUserAjouter_Click(object sender, System.EventArgs e)
        {
            openChildForm(new AddUser());
            hideSubMenu();
        }

        private void btnUserSupprimer_Click(object sender, System.EventArgs e)
        {
            openChildForm(new DeleteUser());
            hideSubMenu();
        }

        private void btnUserRapport_Click(object sender, System.EventArgs e)
        {
            openChildForm(new AfficherUser());
            hideSubMenu();
        }


        private void btnRapStockin_Click(object sender, System.EventArgs e)
        {
            openChildForm(new StockinRapport());
            hideSubMenu();
        }

        private void btnRapTotal_Click(object sender, System.EventArgs e)
        {
            openChildForm(new StockRapport());
            hideSubMenu();
        }

        private void btnRapVente_Click(object sender, System.EventArgs e)
        {
            openChildForm(new VenteRapport());
            hideSubMenu();
        }

        private void btnConnecter_Click(object sender, System.EventArgs e)
        {
            openChildForm(new Login.HelpForm());
            hideSubMenu();
        }

        //Private methods
        // Method to load data into UI components
        private void LoadData()
        {
            var refreshData = dashboardAppInstance.LoadData(dtpStartDate.Value, dtpEndDate.Value);

            if (refreshData)
            {
                // Update UI components with loaded data
                lblNumOrders.Text = dashboardAppInstance.NumOrders.ToString();
                lblTotalRevenue.Text = "$" + dashboardAppInstance.TotalRevenue.ToString();
                lblTotalProfit.Text = "$" + dashboardAppInstance.TotalProfit.ToString();

                lblNumCustomers.Text = dashboardAppInstance.NumCustomers.ToString();
                lblNumSuppliers.Text = dashboardAppInstance.NumSuppliers.ToString();
                lblNumProducts.Text = dashboardAppInstance.NumProducts.ToString();

                // Bind Gross Revenue data to chartGrossRevenue
                chartGrossRevenue.DataSource = dashboardAppInstance.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();

                // Bind Top Products data to chartTopProducts
                chartTopProducts.DataSource = dashboardAppInstance.TopProductsList;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();

                // Bind Understock data to dgvUnderstock (if applicable)
                dgvUnderstock.DataSource = dashboardAppInstance.UnderstockList;
                dgvUnderstock.Columns[0].HeaderText = "Item";
                dgvUnderstock.Columns[1].HeaderText = "Units";
            }
            else
            {
                Console.WriteLine("View not loaded, same query");
            }
        }


        private void btnTday_Click(object sender, EventArgs e)
        {
            // Get today's date
            var today = DateTime.Today;

            // Set start and end dates to today
            dtpStartDate.Value = today;
            dtpEndDate.Value = today;

            // Reload data for today
            LoadData();
        }

        // Event method for button btnOk_Click
        private void btnOk_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Event method for button btnThisMonth_Click
        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            // Get the first day of the current month
            var firstDayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            // Set start date to the first day of the current month
            dtpStartDate.Value = firstDayOfMonth;

            // Set end date to today
            dtpEndDate.Value = DateTime.Today;

            // Reload data for the current month
            LoadData();
        }

        // Event method for button btnWeek_Click
        private void btnWeek_Click(object sender, EventArgs e)
        {
            // Get the start date of the current week (Sunday)
            var sundayOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);

            // Get the end date of the current week (Saturday)
            var saturdayOfWeek = sundayOfWeek.AddDays(6);

            // Set start date to Sunday and end date to Saturday
            dtpStartDate.Value = sundayOfWeek;
            dtpEndDate.Value = saturdayOfWeek;

            // Reload data for the current week
            LoadData();
        }


        private void btnEseAjouter_Click(object sender, EventArgs e)
        {
            openChildForm(new AddEntreprise());
            hideSubMenu();
        }

        private void btnEseSupprimer_Click(object sender, EventArgs e)
        {
            openChildForm(new DeleteEntreprise());
            hideSubMenu();
        }

        private void btnEseRapport_Click(object sender, EventArgs e)
        {
            openChildForm(new AfficherEntreprises());
            hideSubMenu();
        }

        private void btnUserPass_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdatePass(SelectedUtilisateur));
            hideSubMenu();
        }
    }
}
