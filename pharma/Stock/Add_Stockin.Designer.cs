namespace pharma.Stock
{
    partial class Add_Stockin
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpExp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.nudQuantite = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbNomEse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lblQuantite = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrix = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblArticleDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.lblDateExp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLieu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrixUnitaire = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtArticleDetail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNomArticle = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.btnAjouter);
            this.groupControl1.Controls.Add(this.btnReset);
            this.groupControl1.Location = new System.Drawing.Point(-3, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(769, 532);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ajouter StockIn :";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(19, 22);
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
            this.groupBox1.Controls.Add(this.dtpExp);
            this.groupBox1.Controls.Add(this.nudQuantite);
            this.groupBox1.Controls.Add(this.cmbNomEse);
            this.groupBox1.Controls.Add(this.xtraTabControl1);
            this.groupBox1.Controls.Add(this.txtLieu);
            this.groupBox1.Controls.Add(this.txtPrixUnitaire);
            this.groupBox1.Controls.Add(this.txtArticleDetail);
            this.groupBox1.Controls.Add(this.txtNomArticle);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(19, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 417);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dtpExp
            // 
            this.dtpExp.CheckedState.Parent = this.dtpExp;
            this.dtpExp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpExp.ForeColor = System.Drawing.Color.White;
            this.dtpExp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExp.HoverState.Parent = this.dtpExp;
            this.dtpExp.Location = new System.Drawing.Point(95, 257);
            this.dtpExp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.ShadowDecoration.Parent = this.dtpExp;
            this.dtpExp.Size = new System.Drawing.Size(597, 36);
            this.dtpExp.TabIndex = 6;
            this.dtpExp.Value = new System.DateTime(2024, 4, 15, 0, 0, 0, 0);
            this.dtpExp.ValueChanged += new System.EventHandler(this.dtpExp_ValueChanged);
            this.dtpExp.TextChanged += new System.EventHandler(this.dtpExp_TextChanged);
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
            this.nudQuantite.Location = new System.Drawing.Point(95, 134);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.ShadowDecoration.Parent = this.nudQuantite;
            this.nudQuantite.Size = new System.Drawing.Size(100, 36);
            this.nudQuantite.TabIndex = 3;
            this.nudQuantite.ValueChanged += new System.EventHandler(this.nudQuantite_ValueChanged);
            // 
            // cmbNomEse
            // 
            this.cmbNomEse.BackColor = System.Drawing.Color.Transparent;
            this.cmbNomEse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNomEse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomEse.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNomEse.FocusedState.Parent = this.cmbNomEse;
            this.cmbNomEse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNomEse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNomEse.FormattingEnabled = true;
            this.cmbNomEse.HoverState.Parent = this.cmbNomEse;
            this.cmbNomEse.ItemHeight = 30;
            this.cmbNomEse.ItemsAppearance.Parent = this.cmbNomEse;
            this.cmbNomEse.Location = new System.Drawing.Point(95, 175);
            this.cmbNomEse.Name = "cmbNomEse";
            this.cmbNomEse.ShadowDecoration.Parent = this.cmbNomEse;
            this.cmbNomEse.Size = new System.Drawing.Size(597, 36);
            this.cmbNomEse.TabIndex = 4;
            this.cmbNomEse.TextChanged += new System.EventHandler(this.cmbNomEse_TextChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(95, 301);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(597, 96);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lblQuantite);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel4);
            this.xtraTabPage1.Controls.Add(this.lblPrix);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel3);
            this.xtraTabPage1.Controls.Add(this.lblArticleDetail);
            this.xtraTabPage1.Controls.Add(this.lblNom);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel2);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(595, 71);
            this.xtraTabPage1.Text = "Infos:";
            // 
            // lblQuantite
            // 
            this.lblQuantite.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantite.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblQuantite.Location = new System.Drawing.Point(373, 47);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 16);
            this.lblQuantite.TabIndex = 0;
            this.lblQuantite.Text = "-----------";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(316, 47);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(55, 16);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "Quantité:";
            // 
            // lblPrix
            // 
            this.lblPrix.BackColor = System.Drawing.Color.Transparent;
            this.lblPrix.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblPrix.Location = new System.Drawing.Point(373, 14);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(47, 16);
            this.lblPrix.TabIndex = 0;
            this.lblPrix.Text = "-----------";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(300, 14);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(71, 16);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Prix Unitaire:";
            // 
            // lblArticleDetail
            // 
            this.lblArticleDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblArticleDetail.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblArticleDetail.Location = new System.Drawing.Point(80, 47);
            this.lblArticleDetail.Name = "lblArticleDetail";
            this.lblArticleDetail.Size = new System.Drawing.Size(47, 16);
            this.lblArticleDetail.TabIndex = 0;
            this.lblArticleDetail.Text = "-----------";
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNom.Location = new System.Drawing.Point(80, 14);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 16);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "-----------";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(6, 47);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(75, 16);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Article Detail:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(11, 14);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(70, 16);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Nom Article:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.lblDateExp);
            this.xtraTabPage2.Controls.Add(this.lblLieu);
            this.xtraTabPage2.Controls.Add(this.guna2HtmlLabel11);
            this.xtraTabPage2.Controls.Add(this.guna2HtmlLabel12);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(595, 71);
            this.xtraTabPage2.Text = "Suite";
            // 
            // lblDateExp
            // 
            this.lblDateExp.BackColor = System.Drawing.Color.Transparent;
            this.lblDateExp.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblDateExp.Location = new System.Drawing.Point(83, 50);
            this.lblDateExp.Name = "lblDateExp";
            this.lblDateExp.Size = new System.Drawing.Size(47, 16);
            this.lblDateExp.TabIndex = 1;
            this.lblDateExp.Text = "-----------";
            // 
            // lblLieu
            // 
            this.lblLieu.BackColor = System.Drawing.Color.Transparent;
            this.lblLieu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblLieu.Location = new System.Drawing.Point(83, 17);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(47, 16);
            this.lblLieu.TabIndex = 2;
            this.lblLieu.Text = "-----------";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(21, 50);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(57, 16);
            this.guna2HtmlLabel11.TabIndex = 3;
            this.guna2HtmlLabel11.Text = "Date Exp:";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(38, 17);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(29, 16);
            this.guna2HtmlLabel12.TabIndex = 4;
            this.guna2HtmlLabel12.Text = "Lieu:";
            // 
            // txtLieu
            // 
            this.txtLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLieu.AutoSize = true;
            this.txtLieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLieu.DefaultText = "";
            this.txtLieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLieu.DisabledState.Parent = this.txtLieu;
            this.txtLieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLieu.FocusedState.Parent = this.txtLieu;
            this.txtLieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLieu.HoverState.Parent = this.txtLieu;
            this.txtLieu.Location = new System.Drawing.Point(95, 215);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.PasswordChar = '\0';
            this.txtLieu.PlaceholderText = "";
            this.txtLieu.SelectedText = "";
            this.txtLieu.ShadowDecoration.Parent = this.txtLieu;
            this.txtLieu.Size = new System.Drawing.Size(597, 36);
            this.txtLieu.TabIndex = 5;
            this.txtLieu.TextChanged += new System.EventHandler(this.txtLieu_TextChanged);
            // 
            // txtPrixUnitaire
            // 
            this.txtPrixUnitaire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrixUnitaire.AutoSize = true;
            this.txtPrixUnitaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrixUnitaire.DefaultText = "";
            this.txtPrixUnitaire.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrixUnitaire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrixUnitaire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrixUnitaire.DisabledState.Parent = this.txtPrixUnitaire;
            this.txtPrixUnitaire.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrixUnitaire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrixUnitaire.FocusedState.Parent = this.txtPrixUnitaire;
            this.txtPrixUnitaire.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrixUnitaire.HoverState.Parent = this.txtPrixUnitaire;
            this.txtPrixUnitaire.Location = new System.Drawing.Point(95, 94);
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.PasswordChar = '\0';
            this.txtPrixUnitaire.PlaceholderText = "";
            this.txtPrixUnitaire.SelectedText = "";
            this.txtPrixUnitaire.ShadowDecoration.Parent = this.txtPrixUnitaire;
            this.txtPrixUnitaire.Size = new System.Drawing.Size(597, 36);
            this.txtPrixUnitaire.TabIndex = 2;
            this.txtPrixUnitaire.TextChanged += new System.EventHandler(this.txtPrixUnitaire_TextChanged);
            // 
            // txtArticleDetail
            // 
            this.txtArticleDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticleDetail.AutoSize = true;
            this.txtArticleDetail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArticleDetail.DefaultText = "";
            this.txtArticleDetail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtArticleDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtArticleDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArticleDetail.DisabledState.Parent = this.txtArticleDetail;
            this.txtArticleDetail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArticleDetail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArticleDetail.FocusedState.Parent = this.txtArticleDetail;
            this.txtArticleDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArticleDetail.HoverState.Parent = this.txtArticleDetail;
            this.txtArticleDetail.Location = new System.Drawing.Point(95, 53);
            this.txtArticleDetail.Name = "txtArticleDetail";
            this.txtArticleDetail.PasswordChar = '\0';
            this.txtArticleDetail.PlaceholderText = "";
            this.txtArticleDetail.SelectedText = "";
            this.txtArticleDetail.ShadowDecoration.Parent = this.txtArticleDetail;
            this.txtArticleDetail.Size = new System.Drawing.Size(597, 36);
            this.txtArticleDetail.TabIndex = 1;
            this.txtArticleDetail.TextChanged += new System.EventHandler(this.txtArticleDetail_TextChanged);
            // 
            // txtNomArticle
            // 
            this.txtNomArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomArticle.AutoSize = true;
            this.txtNomArticle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomArticle.DefaultText = "";
            this.txtNomArticle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomArticle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomArticle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomArticle.DisabledState.Parent = this.txtNomArticle;
            this.txtNomArticle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomArticle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomArticle.FocusedState.Parent = this.txtNomArticle;
            this.txtNomArticle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomArticle.HoverState.Parent = this.txtNomArticle;
            this.txtNomArticle.Location = new System.Drawing.Point(95, 14);
            this.txtNomArticle.Name = "txtNomArticle";
            this.txtNomArticle.PasswordChar = '\0';
            this.txtNomArticle.PlaceholderText = "";
            this.txtNomArticle.SelectedText = "";
            this.txtNomArticle.ShadowDecoration.Parent = this.txtNomArticle;
            this.txtNomArticle.Size = new System.Drawing.Size(597, 36);
            this.txtNomArticle.TabIndex = 0;
            this.txtNomArticle.TextChanged += new System.EventHandler(this.txtNomArticle_TextChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(39, 267);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Date Exp:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(64, 228);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Lieu:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 184);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Nom Entreprise :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(41, 144);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Quantité:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Prix Unitaire:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Article Detail:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Nom Article:";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAjouter.AutoSize = true;
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(120, 469);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(278, 54);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
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
            this.btnReset.Location = new System.Drawing.Point(416, 469);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(289, 54);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 534);
            this.Controls.Add(this.groupControl1);
            this.Name = "Add_Stock";
            this.Text = "Add_Stock";
            this.Load += new System.EventHandler(this.Add_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExp;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQuantite;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNomEse;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantite;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrix;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblArticleDetail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateExp;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLieu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2TextBox txtLieu;
        private Guna.UI2.WinForms.Guna2TextBox txtPrixUnitaire;
        private Guna.UI2.WinForms.Guna2TextBox txtArticleDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtNomArticle;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnReset;
    }
}