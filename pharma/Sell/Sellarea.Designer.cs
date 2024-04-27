namespace pharma.Sell
{
    partial class Sellarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCommande = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudQuantite = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbNomClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbArticleAVendre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrixUnitaire = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNomArticle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.lblAdresseClient = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTelephoneCLient = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrenom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNomCLient = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.button11 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblQuantite = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrixTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbIdClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.button11);
            this.groupControl1.Controls.Add(this.button2);
            this.groupControl1.Controls.Add(this.btnReset);
            this.groupControl1.Location = new System.Drawing.Point(3, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(757, 565);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Zonde de vente :";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCommande);
            this.groupBox2.Location = new System.Drawing.Point(22, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 129);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // dgvCommande
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvCommande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommande.BackgroundColor = System.Drawing.Color.White;
            this.dgvCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCommande.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCommande.ColumnHeadersHeight = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommande.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCommande.EnableHeadersVisualStyles = false;
            this.dgvCommande.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCommande.Location = new System.Drawing.Point(110, 13);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.RowHeadersVisible = false;
            this.dgvCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommande.Size = new System.Drawing.Size(569, 109);
            this.dgvCommande.TabIndex = 0;
            this.dgvCommande.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvCommande.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCommande.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCommande.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCommande.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCommande.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCommande.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCommande.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCommande.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCommande.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCommande.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgvCommande.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCommande.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCommande.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvCommande.ThemeStyle.ReadOnly = false;
            this.dgvCommande.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCommande.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCommande.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgvCommande.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvCommande.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCommande.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCommande.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(22, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 25);
            this.button1.TabIndex = 23;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.cmbIdClient);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.nudQuantite);
            this.groupBox1.Controls.Add(this.cmbNomClient);
            this.groupBox1.Controls.Add(this.cmbArticleAVendre);
            this.groupBox1.Controls.Add(this.xtraTabControl1);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(22, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 313);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // nudQuantite
            // 
            this.nudQuantite.BackColor = System.Drawing.Color.Transparent;
            this.nudQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQuantite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudQuantite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudQuantite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudQuantite.DisabledState.Parent = this.nudQuantite;
            this.nudQuantite.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudQuantite.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudQuantite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudQuantite.FocusedState.Parent = this.nudQuantite;
            this.nudQuantite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudQuantite.Location = new System.Drawing.Point(112, 142);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.ShadowDecoration.Parent = this.nudQuantite;
            this.nudQuantite.Size = new System.Drawing.Size(100, 36);
            this.nudQuantite.TabIndex = 22;
            // 
            // cmbNomClient
            // 
            this.cmbNomClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNomClient.BackColor = System.Drawing.Color.Transparent;
            this.cmbNomClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNomClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomClient.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNomClient.FocusedState.Parent = this.cmbNomClient;
            this.cmbNomClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNomClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNomClient.FormattingEnabled = true;
            this.cmbNomClient.HoverState.Parent = this.cmbNomClient;
            this.cmbNomClient.ItemHeight = 30;
            this.cmbNomClient.ItemsAppearance.Parent = this.cmbNomClient;
            this.cmbNomClient.Location = new System.Drawing.Point(111, 17);
            this.cmbNomClient.Name = "cmbNomClient";
            this.cmbNomClient.ShadowDecoration.Parent = this.cmbNomClient;
            this.cmbNomClient.Size = new System.Drawing.Size(570, 36);
            this.cmbNomClient.TabIndex = 20;
            this.cmbNomClient.SelectedIndexChanged += new System.EventHandler(this.cmbNomClient_SelectedIndexChanged);
            this.cmbNomClient.TextChanged += new System.EventHandler(this.cmbNomClient_TextChanged);
            // 
            // cmbArticleAVendre
            // 
            this.cmbArticleAVendre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbArticleAVendre.BackColor = System.Drawing.Color.Transparent;
            this.cmbArticleAVendre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbArticleAVendre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticleAVendre.FocusedColor = System.Drawing.Color.Empty;
            this.cmbArticleAVendre.FocusedState.Parent = this.cmbArticleAVendre;
            this.cmbArticleAVendre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbArticleAVendre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbArticleAVendre.FormattingEnabled = true;
            this.cmbArticleAVendre.HoverState.Parent = this.cmbArticleAVendre;
            this.cmbArticleAVendre.ItemHeight = 30;
            this.cmbArticleAVendre.ItemsAppearance.Parent = this.cmbArticleAVendre;
            this.cmbArticleAVendre.Location = new System.Drawing.Point(111, 100);
            this.cmbArticleAVendre.Name = "cmbArticleAVendre";
            this.cmbArticleAVendre.ShadowDecoration.Parent = this.cmbArticleAVendre;
            this.cmbArticleAVendre.Size = new System.Drawing.Size(570, 36);
            this.cmbArticleAVendre.TabIndex = 21;
            this.cmbArticleAVendre.TextChanged += new System.EventHandler(this.cmbArticleAVendre_TextChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(111, 187);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(570, 106);
            this.xtraTabControl1.TabIndex = 19;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lblPrixTotal);
            this.xtraTabPage1.Controls.Add(this.lblQuantite);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel3);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel4);
            this.xtraTabPage1.Controls.Add(this.lblPrixUnitaire);
            this.xtraTabPage1.Controls.Add(this.lblNomArticle);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel2);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(568, 81);
            this.xtraTabPage1.Text = "Infos:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(319, 14);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(55, 16);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Quantité:";
            // 
            // lblPrixUnitaire
            // 
            this.lblPrixUnitaire.BackColor = System.Drawing.Color.Transparent;
            this.lblPrixUnitaire.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblPrixUnitaire.Location = new System.Drawing.Point(90, 47);
            this.lblPrixUnitaire.Name = "lblPrixUnitaire";
            this.lblPrixUnitaire.Size = new System.Drawing.Size(47, 16);
            this.lblPrixUnitaire.TabIndex = 0;
            this.lblPrixUnitaire.Text = "-----------";
            // 
            // lblNomArticle
            // 
            this.lblNomArticle.BackColor = System.Drawing.Color.Transparent;
            this.lblNomArticle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNomArticle.Location = new System.Drawing.Point(90, 14);
            this.lblNomArticle.Name = "lblNomArticle";
            this.lblNomArticle.Size = new System.Drawing.Size(47, 16);
            this.lblNomArticle.TabIndex = 0;
            this.lblNomArticle.Text = "-----------";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(11, 47);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(71, 16);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Prix Unitaire:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 14);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(70, 16);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Nom Article:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.lblAdresseClient);
            this.xtraTabPage2.Controls.Add(this.guna2HtmlLabel10);
            this.xtraTabPage2.Controls.Add(this.lblTelephoneCLient);
            this.xtraTabPage2.Controls.Add(this.guna2HtmlLabel12);
            this.xtraTabPage2.Controls.Add(this.lblPrenom);
            this.xtraTabPage2.Controls.Add(this.lblNomCLient);
            this.xtraTabPage2.Controls.Add(this.guna2HtmlLabel15);
            this.xtraTabPage2.Controls.Add(this.guna2HtmlLabel16);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(568, 81);
            this.xtraTabPage2.Text = "Client";
            // 
            // lblAdresseClient
            // 
            this.lblAdresseClient.BackColor = System.Drawing.Color.Transparent;
            this.lblAdresseClient.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblAdresseClient.Location = new System.Drawing.Point(374, 49);
            this.lblAdresseClient.Name = "lblAdresseClient";
            this.lblAdresseClient.Size = new System.Drawing.Size(47, 16);
            this.lblAdresseClient.TabIndex = 1;
            this.lblAdresseClient.Text = "-----------";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(308, 49);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(50, 16);
            this.guna2HtmlLabel10.TabIndex = 2;
            this.guna2HtmlLabel10.Text = "Adresse:";
            // 
            // lblTelephoneCLient
            // 
            this.lblTelephoneCLient.BackColor = System.Drawing.Color.Transparent;
            this.lblTelephoneCLient.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTelephoneCLient.Location = new System.Drawing.Point(374, 16);
            this.lblTelephoneCLient.Name = "lblTelephoneCLient";
            this.lblTelephoneCLient.Size = new System.Drawing.Size(47, 16);
            this.lblTelephoneCLient.TabIndex = 3;
            this.lblTelephoneCLient.Text = "-----------";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(292, 16);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(66, 16);
            this.guna2HtmlLabel12.TabIndex = 4;
            this.guna2HtmlLabel12.Text = "Téléphone:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblPrenom.Location = new System.Drawing.Point(72, 49);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(47, 16);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "-----------";
            // 
            // lblNomCLient
            // 
            this.lblNomCLient.BackColor = System.Drawing.Color.Transparent;
            this.lblNomCLient.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNomCLient.Location = new System.Drawing.Point(72, 16);
            this.lblNomCLient.Name = "lblNomCLient";
            this.lblNomCLient.Size = new System.Drawing.Size(47, 16);
            this.lblNomCLient.TabIndex = 6;
            this.lblNomCLient.Text = "-----------";
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(10, 49);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(49, 16);
            this.guna2HtmlLabel15.TabIndex = 7;
            this.guna2HtmlLabel15.Text = "Prénom:";
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(27, 16);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(32, 16);
            this.guna2HtmlLabel16.TabIndex = 8;
            this.guna2HtmlLabel16.Text = "Nom:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(50, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Quantité :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Article à vendre :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Nom Client :";
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button11.AutoSize = true;
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(246, 494);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(261, 63);
            this.button11.TabIndex = 8;
            this.button11.Text = "Soumettre la commande";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(19, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ajouter à la commande";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.Teal;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(554, 494);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(181, 63);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Annuler";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblQuantite
            // 
            this.lblQuantite.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantite.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblQuantite.Location = new System.Drawing.Point(377, 15);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 16);
            this.lblQuantite.TabIndex = 0;
            this.lblQuantite.Text = "-----------";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(319, 47);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(58, 16);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "Prix Total:";
            // 
            // lblPrixTotal
            // 
            this.lblPrixTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrixTotal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblPrixTotal.Location = new System.Drawing.Point(380, 48);
            this.lblPrixTotal.Name = "lblPrixTotal";
            this.lblPrixTotal.Size = new System.Drawing.Size(47, 16);
            this.lblPrixTotal.TabIndex = 0;
            this.lblPrixTotal.Text = "-----------";
            // 
            // cmbIdClient
            // 
            this.cmbIdClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdClient.BackColor = System.Drawing.Color.Transparent;
            this.cmbIdClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIdClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdClient.FocusedColor = System.Drawing.Color.Empty;
            this.cmbIdClient.FocusedState.Parent = this.cmbIdClient;
            this.cmbIdClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIdClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIdClient.FormattingEnabled = true;
            this.cmbIdClient.HoverState.Parent = this.cmbIdClient;
            this.cmbIdClient.ItemHeight = 30;
            this.cmbIdClient.ItemsAppearance.Parent = this.cmbIdClient;
            this.cmbIdClient.Location = new System.Drawing.Point(111, 59);
            this.cmbIdClient.Name = "cmbIdClient";
            this.cmbIdClient.ShadowDecoration.Parent = this.cmbIdClient;
            this.cmbIdClient.Size = new System.Drawing.Size(568, 36);
            this.cmbIdClient.TabIndex = 24;
            this.cmbIdClient.TextChanged += new System.EventHandler(this.cmbIdClient_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(51, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Id client  :";
            // 
            // Sellarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 582);
            this.Controls.Add(this.groupControl1);
            this.Name = "Sellarea";
            this.Text = "Sellarea";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrixUnitaire;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomArticle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnReset;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNomClient;
        private Guna.UI2.WinForms.Guna2ComboBox cmbArticleAVendre;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQuantite;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdresseClient;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTelephoneCLient;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrenom;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomCLient;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCommande;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrixTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantite;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIdClient;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}