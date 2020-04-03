namespace FrontEndGSBrevet.Views.Public.Contracts
{
    partial class uc_MainContract
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_tableHeader = new Guna.UI.WinForms.GunaPanel();
            this.lbl_actions = new Guna.UI.WinForms.GunaLabel();
            this.lbl_price = new Guna.UI.WinForms.GunaLabel();
            this.lbl_duration = new Guna.UI.WinForms.GunaLabel();
            this.lbl_create_date = new Guna.UI.WinForms.GunaLabel();
            this.lbl_company = new Guna.UI.WinForms.GunaLabel();
            this.lbl_patent = new Guna.UI.WinForms.GunaLabel();
            this.lbl_id = new Guna.UI.WinForms.GunaLabel();
            this.pnl_contracts = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.tbox_search = new Guna.UI.WinForms.GunaTextBox();
            this.btn_search = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_create_contract = new Guna.UI.WinForms.GunaButton();
            this.btn_refresh = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_orderby_company = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_orderby_patent = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_orderby_createDate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_tableHeader.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_tableHeader
            // 
            this.pnl_tableHeader.Controls.Add(this.lbl_actions);
            this.pnl_tableHeader.Controls.Add(this.lbl_price);
            this.pnl_tableHeader.Controls.Add(this.lbl_duration);
            this.pnl_tableHeader.Controls.Add(this.lbl_create_date);
            this.pnl_tableHeader.Controls.Add(this.lbl_company);
            this.pnl_tableHeader.Controls.Add(this.lbl_patent);
            this.pnl_tableHeader.Controls.Add(this.lbl_id);
            this.pnl_tableHeader.Location = new System.Drawing.Point(55, 129);
            this.pnl_tableHeader.Name = "pnl_tableHeader";
            this.pnl_tableHeader.Size = new System.Drawing.Size(1010, 40);
            this.pnl_tableHeader.TabIndex = 2;
            // 
            // lbl_actions
            // 
            this.lbl_actions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actions.Location = new System.Drawing.Point(900, 10);
            this.lbl_actions.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl_actions.Name = "lbl_actions";
            this.lbl_actions.Size = new System.Drawing.Size(100, 20);
            this.lbl_actions.TabIndex = 6;
            this.lbl_actions.Text = "ACTIONS";
            this.lbl_actions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(750, 10);
            this.lbl_price.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(140, 20);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "PRIX";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_duration
            // 
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.Location = new System.Drawing.Point(610, 10);
            this.lbl_duration.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(140, 20);
            this.lbl_duration.TabIndex = 4;
            this.lbl_duration.Text = "DUREE";
            this.lbl_duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_create_date
            // 
            this.lbl_create_date.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_create_date.Location = new System.Drawing.Point(460, 10);
            this.lbl_create_date.MaximumSize = new System.Drawing.Size(142, 20);
            this.lbl_create_date.Name = "lbl_create_date";
            this.lbl_create_date.Size = new System.Drawing.Size(142, 20);
            this.lbl_create_date.TabIndex = 3;
            this.lbl_create_date.Text = "DATE DE CREATION";
            this.lbl_create_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_company
            // 
            this.lbl_company.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company.Location = new System.Drawing.Point(310, 10);
            this.lbl_company.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(140, 20);
            this.lbl_company.TabIndex = 2;
            this.lbl_company.Text = "ENTREPRISE";
            this.lbl_company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_patent
            // 
            this.lbl_patent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patent.Location = new System.Drawing.Point(160, 10);
            this.lbl_patent.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_patent.Name = "lbl_patent";
            this.lbl_patent.Size = new System.Drawing.Size(140, 20);
            this.lbl_patent.TabIndex = 1;
            this.lbl_patent.Text = "BREVET";
            this.lbl_patent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(10, 10);
            this.lbl_id.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(140, 20);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // pnl_contracts
            // 
            this.pnl_contracts.AutoScroll = true;
            this.pnl_contracts.Location = new System.Drawing.Point(55, 175);
            this.pnl_contracts.Name = "pnl_contracts";
            this.pnl_contracts.Size = new System.Drawing.Size(1040, 546);
            this.pnl_contracts.TabIndex = 3;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.tbox_search);
            this.gunaShadowPanel1.Controls.Add(this.btn_search);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(45, 13);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1040, 50);
            this.gunaShadowPanel1.TabIndex = 8;
            // 
            // tbox_search
            // 
            this.tbox_search.BaseColor = System.Drawing.Color.White;
            this.tbox_search.BorderColor = System.Drawing.Color.Silver;
            this.tbox_search.BorderSize = 0;
            this.tbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_search.FocusedBaseColor = System.Drawing.Color.White;
            this.tbox_search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_search.FocusedForeColor = System.Drawing.Color.Black;
            this.tbox_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.ForeColor = System.Drawing.Color.Gray;
            this.tbox_search.Location = new System.Drawing.Point(65, 5);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.PasswordChar = '\0';
            this.tbox_search.Size = new System.Drawing.Size(945, 40);
            this.tbox_search.TabIndex = 1;
            this.tbox_search.Text = "Rechercher...";
            this.tbox_search.TextOffsetX = 15;
            // 
            // btn_search
            // 
            this.btn_search.AnimationHoverSpeed = 0.07F;
            this.btn_search.AnimationSpeed = 0.03F;
            this.btn_search.BaseColor = System.Drawing.Color.White;
            this.btn_search.BorderColor = System.Drawing.Color.Black;
            this.btn_search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_search.FocusedColor = System.Drawing.Color.Empty;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = global::FrontEndGSBrevet.Properties.Resources.search;
            this.btn_search.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_search.Location = new System.Drawing.Point(19, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_search.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_search.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.search_on;
            this.btn_search.OnPressedColor = System.Drawing.Color.Black;
            this.btn_search.Size = new System.Drawing.Size(40, 40);
            this.btn_search.TabIndex = 0;
            // 
            // btn_create_contract
            // 
            this.btn_create_contract.AnimationHoverSpeed = 0.07F;
            this.btn_create_contract.AnimationSpeed = 0.03F;
            this.btn_create_contract.BackColor = System.Drawing.Color.Transparent;
            this.btn_create_contract.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_create_contract.BorderColor = System.Drawing.Color.Black;
            this.btn_create_contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_contract.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_create_contract.FocusedColor = System.Drawing.Color.Empty;
            this.btn_create_contract.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_contract.ForeColor = System.Drawing.Color.White;
            this.btn_create_contract.Image = global::FrontEndGSBrevet.Properties.Resources.plus;
            this.btn_create_contract.ImageSize = new System.Drawing.Size(12, 12);
            this.btn_create_contract.Location = new System.Drawing.Point(895, 77);
            this.btn_create_contract.Name = "btn_create_contract";
            this.btn_create_contract.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_create_contract.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_create_contract.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_create_contract.OnHoverImage = null;
            this.btn_create_contract.OnPressedColor = System.Drawing.Color.Black;
            this.btn_create_contract.Radius = 6;
            this.btn_create_contract.Size = new System.Drawing.Size(170, 42);
            this.btn_create_contract.TabIndex = 7;
            this.btn_create_contract.Text = "CREER UN CONTRAT";
            this.btn_create_contract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_create_contract.Click += new System.EventHandler(this.btn_create_contract_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.AnimationHoverSpeed = 0.07F;
            this.btn_refresh.AnimationSpeed = 0.03F;
            this.btn_refresh.BaseColor = System.Drawing.Color.White;
            this.btn_refresh.BorderColor = System.Drawing.Color.Black;
            this.btn_refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_refresh.FocusedColor = System.Drawing.Color.Empty;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = global::FrontEndGSBrevet.Properties.Resources.refresh_off;
            this.btn_refresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_refresh.Location = new System.Drawing.Point(837, 77);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_refresh.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.refresh_on;
            this.btn_refresh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_refresh.Size = new System.Drawing.Size(42, 42);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_orderby_company
            // 
            this.btn_orderby_company.AnimationHoverSpeed = 0.07F;
            this.btn_orderby_company.AnimationSpeed = 0.03F;
            this.btn_orderby_company.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderby_company.BaseColor = System.Drawing.Color.White;
            this.btn_orderby_company.BorderColor = System.Drawing.Color.Black;
            this.btn_orderby_company.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_orderby_company.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_company.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_company.CheckedForeColor = System.Drawing.Color.White;
            this.btn_orderby_company.CheckedImage = null;
            this.btn_orderby_company.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_company.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_orderby_company.FocusedColor = System.Drawing.Color.Empty;
            this.btn_orderby_company.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderby_company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_company.Image = null;
            this.btn_orderby_company.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_orderby_company.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_company.Location = new System.Drawing.Point(347, 77);
            this.btn_orderby_company.Name = "btn_orderby_company";
            this.btn_orderby_company.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_company.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_company.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_orderby_company.OnHoverImage = null;
            this.btn_orderby_company.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_company.OnPressedColor = System.Drawing.Color.Black;
            this.btn_orderby_company.Radius = 13;
            this.btn_orderby_company.Size = new System.Drawing.Size(140, 30);
            this.btn_orderby_company.TabIndex = 14;
            this.btn_orderby_company.Text = "ENTREPRISE";
            this.btn_orderby_company.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_orderby_company.Click += new System.EventHandler(this.btn_orderby_company_Click);
            // 
            // btn_orderby_patent
            // 
            this.btn_orderby_patent.AnimationHoverSpeed = 0.07F;
            this.btn_orderby_patent.AnimationSpeed = 0.03F;
            this.btn_orderby_patent.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderby_patent.BaseColor = System.Drawing.Color.White;
            this.btn_orderby_patent.BorderColor = System.Drawing.Color.Black;
            this.btn_orderby_patent.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_orderby_patent.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_patent.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_patent.CheckedForeColor = System.Drawing.Color.White;
            this.btn_orderby_patent.CheckedImage = null;
            this.btn_orderby_patent.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_patent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_orderby_patent.FocusedColor = System.Drawing.Color.Empty;
            this.btn_orderby_patent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderby_patent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_patent.Image = null;
            this.btn_orderby_patent.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_orderby_patent.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_patent.Location = new System.Drawing.Point(201, 77);
            this.btn_orderby_patent.Name = "btn_orderby_patent";
            this.btn_orderby_patent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_patent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_patent.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_orderby_patent.OnHoverImage = null;
            this.btn_orderby_patent.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_patent.OnPressedColor = System.Drawing.Color.Black;
            this.btn_orderby_patent.Radius = 13;
            this.btn_orderby_patent.Size = new System.Drawing.Size(140, 30);
            this.btn_orderby_patent.TabIndex = 15;
            this.btn_orderby_patent.Text = "BREVET";
            this.btn_orderby_patent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_orderby_patent.Click += new System.EventHandler(this.btn_orderby_patent_Click);
            // 
            // btn_orderby_createDate
            // 
            this.btn_orderby_createDate.AnimationHoverSpeed = 0.07F;
            this.btn_orderby_createDate.AnimationSpeed = 0.03F;
            this.btn_orderby_createDate.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderby_createDate.BaseColor = System.Drawing.Color.White;
            this.btn_orderby_createDate.BorderColor = System.Drawing.Color.Black;
            this.btn_orderby_createDate.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_orderby_createDate.Checked = true;
            this.btn_orderby_createDate.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_createDate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_createDate.CheckedForeColor = System.Drawing.Color.White;
            this.btn_orderby_createDate.CheckedImage = null;
            this.btn_orderby_createDate.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_createDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_orderby_createDate.FocusedColor = System.Drawing.Color.Empty;
            this.btn_orderby_createDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderby_createDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_createDate.Image = null;
            this.btn_orderby_createDate.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_orderby_createDate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_createDate.Location = new System.Drawing.Point(55, 77);
            this.btn_orderby_createDate.Name = "btn_orderby_createDate";
            this.btn_orderby_createDate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_createDate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_createDate.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_orderby_createDate.OnHoverImage = null;
            this.btn_orderby_createDate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_createDate.OnPressedColor = System.Drawing.Color.Black;
            this.btn_orderby_createDate.Radius = 13;
            this.btn_orderby_createDate.Size = new System.Drawing.Size(140, 30);
            this.btn_orderby_createDate.TabIndex = 16;
            this.btn_orderby_createDate.Text = "DATE DE CREATION";
            this.btn_orderby_createDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_orderby_createDate.Click += new System.EventHandler(this.btn_orderby_createDate_Click);
            // 
            // uc_MainContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_orderby_createDate);
            this.Controls.Add(this.btn_orderby_patent);
            this.Controls.Add(this.btn_orderby_company);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.btn_create_contract);
            this.Controls.Add(this.pnl_contracts);
            this.Controls.Add(this.pnl_tableHeader);
            this.Name = "uc_MainContract";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_MainContract_Load);
            this.pnl_tableHeader.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Guna.UI.WinForms.GunaPanel pnl_tableHeader;
        private Guna.UI.WinForms.GunaLabel lbl_actions;
        private Guna.UI.WinForms.GunaLabel lbl_price;
        private Guna.UI.WinForms.GunaLabel lbl_duration;
        private Guna.UI.WinForms.GunaLabel lbl_create_date;
        private Guna.UI.WinForms.GunaLabel lbl_company;
        private Guna.UI.WinForms.GunaLabel lbl_patent;
        private Guna.UI.WinForms.GunaLabel lbl_id;
        private System.Windows.Forms.FlowLayoutPanel pnl_contracts;
        private Guna.UI.WinForms.GunaButton btn_create_contract;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaCircleButton btn_search;
        private Guna.UI.WinForms.GunaTextBox tbox_search;
        #endregion

        private Guna.UI.WinForms.GunaCircleButton btn_refresh;
        private Guna.UI.WinForms.GunaAdvenceButton btn_orderby_company;
        private Guna.UI.WinForms.GunaAdvenceButton btn_orderby_patent;
        private Guna.UI.WinForms.GunaAdvenceButton btn_orderby_createDate;
    }
}
