namespace pharma.Stock
{
    partial class DeleteStockin
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cmbIdArticle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbNomArticle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lblQuantite = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrixUnitaire = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblArticleDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNomArticle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.lblDateExp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLieu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSupprimer.AutoSize = true;
            this.btnSupprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(237, 344);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(289, 63);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // cmbIdArticle
            // 
            this.cmbIdArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdArticle.BackColor = System.Drawing.Color.Transparent;
            this.cmbIdArticle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIdArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdArticle.FocusedColor = System.Drawing.Color.Empty;
            this.cmbIdArticle.FocusedState.Parent = this.cmbIdArticle;
            this.cmbIdArticle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIdArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIdArticle.FormattingEnabled = true;
            this.cmbIdArticle.HoverState.Parent = this.cmbIdArticle;
            this.cmbIdArticle.ItemHeight = 30;
            this.cmbIdArticle.ItemsAppearance.Parent = this.cmbIdArticle;
            this.cmbIdArticle.Location = new System.Drawing.Point(96, 62);
            this.cmbIdArticle.Name = "cmbIdArticle";
            this.cmbIdArticle.ShadowDecoration.Parent = this.cmbIdArticle;
            this.cmbIdArticle.Size = new System.Drawing.Size(561, 36);
            this.cmbIdArticle.TabIndex = 17;
            this.cmbIdArticle.TextChanged += new System.EventHandler(this.cmbIdArticle_TextChanged);
            // 
            // cmbNomArticle
            // 
            this.cmbNomArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNomArticle.BackColor = System.Drawing.Color.Transparent;
            this.cmbNomArticle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNomArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomArticle.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNomArticle.FocusedState.Parent = this.cmbNomArticle;
            this.cmbNomArticle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNomArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNomArticle.FormattingEnabled = true;
            this.cmbNomArticle.HoverState.Parent = this.cmbNomArticle;
            this.cmbNomArticle.ItemHeight = 30;
            this.cmbNomArticle.ItemsAppearance.Parent = this.cmbNomArticle;
            this.cmbNomArticle.Location = new System.Drawing.Point(96, 20);
            this.cmbNomArticle.Name = "cmbNomArticle";
            this.cmbNomArticle.ShadowDecoration.Parent = this.cmbNomArticle;
            this.cmbNomArticle.Size = new System.Drawing.Size(561, 36);
            this.cmbNomArticle.TabIndex = 17;
            this.cmbNomArticle.TextChanged += new System.EventHandler(this.cmbNomArticle_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Nom d\'article   :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Id d\'article  :";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(24, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.xtraTabControl1);
            this.groupBox1.Controls.Add(this.cmbIdArticle);
            this.groupBox1.Controls.Add(this.cmbNomArticle);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(24, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 261);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(95, 145);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(561, 96);
            this.xtraTabControl1.TabIndex = 20;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lblQuantite);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel4);
            this.xtraTabPage1.Controls.Add(this.lblPrixUnitaire);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel3);
            this.xtraTabPage1.Controls.Add(this.lblArticleDetail);
            this.xtraTabPage1.Controls.Add(this.lblNomArticle);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel2);
            this.xtraTabPage1.Controls.Add(this.guna2HtmlLabel1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(559, 71);
            this.xtraTabPage1.Text = "Infos:";
            // 
            // lblQuantite
            // 
            this.lblQuantite.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantite.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblQuantite.Location = new System.Drawing.Point(355, 47);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 16);
            this.lblQuantite.TabIndex = 0;
            this.lblQuantite.Text = "-----------";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(298, 47);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(55, 16);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "Quantité:";
            // 
            // lblPrixUnitaire
            // 
            this.lblPrixUnitaire.BackColor = System.Drawing.Color.Transparent;
            this.lblPrixUnitaire.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblPrixUnitaire.Location = new System.Drawing.Point(355, 14);
            this.lblPrixUnitaire.Name = "lblPrixUnitaire";
            this.lblPrixUnitaire.Size = new System.Drawing.Size(47, 16);
            this.lblPrixUnitaire.TabIndex = 0;
            this.lblPrixUnitaire.Text = "-----------";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(282, 14);
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
            // lblNomArticle
            // 
            this.lblNomArticle.BackColor = System.Drawing.Color.Transparent;
            this.lblNomArticle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNomArticle.Location = new System.Drawing.Point(80, 14);
            this.lblNomArticle.Name = "lblNomArticle";
            this.lblNomArticle.Size = new System.Drawing.Size(47, 16);
            this.lblNomArticle.TabIndex = 0;
            this.lblNomArticle.Text = "-----------";
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
            this.xtraTabPage2.Size = new System.Drawing.Size(559, 71);
            this.xtraTabPage2.Text = "Suite";
            // 
            // lblDateExp
            // 
            this.lblDateExp.BackColor = System.Drawing.Color.Transparent;
            this.lblDateExp.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblDateExp.Location = new System.Drawing.Point(83, 47);
            this.lblDateExp.Name = "lblDateExp";
            this.lblDateExp.Size = new System.Drawing.Size(47, 16);
            this.lblDateExp.TabIndex = 1;
            this.lblDateExp.Text = "-----------";
            // 
            // lblLieu
            // 
            this.lblLieu.BackColor = System.Drawing.Color.Transparent;
            this.lblLieu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblLieu.Location = new System.Drawing.Point(83, 12);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(47, 16);
            this.lblLieu.TabIndex = 2;
            this.lblLieu.Text = "-----------";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(21, 45);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(57, 16);
            this.guna2HtmlLabel11.TabIndex = 3;
            this.guna2HtmlLabel11.Text = "Date Exp:";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(49, 12);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(29, 16);
            this.guna2HtmlLabel12.TabIndex = 4;
            this.guna2HtmlLabel12.Text = "Lieu:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.btnSupprimer);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(17, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(733, 480);
            this.groupControl1.TabIndex = 32;
            this.groupControl1.Text = "Supprimer StockIn :";
            // 
            // DeleteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 501);
            this.Controls.Add(this.groupControl1);
            this.Name = "DeleteStock";
            this.Text = "DeleteStock";
            this.Load += new System.EventHandler(this.DeleteStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIdArticle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNomArticle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantite;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrixUnitaire;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblArticleDetail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomArticle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateExp;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLieu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
    }
}