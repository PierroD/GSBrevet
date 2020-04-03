namespace FrontEndGSBrevet.Views.Public.Companies
{
    partial class uc_MainCompany
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
            this.lbl_duration = new Guna.UI.WinForms.GunaLabel();
            this.lbl_deposit_date = new Guna.UI.WinForms.GunaLabel();
            this.lbl_company = new Guna.UI.WinForms.GunaLabel();
            this.lbl_molecule = new Guna.UI.WinForms.GunaLabel();
            this.lbl_number = new Guna.UI.WinForms.GunaLabel();
            this.pnl_companies = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_orderby_name = new Guna.UI.WinForms.GunaButton();
            this.btn_orderby_city = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.tbox_search = new Guna.UI.WinForms.GunaTextBox();
            this.btn_search = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_create_company = new Guna.UI.WinForms.GunaButton();
            this.btn_refresh = new Guna.UI.WinForms.GunaCircleButton();
            this.pnl_tableHeader.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_tableHeader
            // 
            this.pnl_tableHeader.Controls.Add(this.lbl_actions);
            this.pnl_tableHeader.Controls.Add(this.lbl_duration);
            this.pnl_tableHeader.Controls.Add(this.lbl_deposit_date);
            this.pnl_tableHeader.Controls.Add(this.lbl_company);
            this.pnl_tableHeader.Controls.Add(this.lbl_molecule);
            this.pnl_tableHeader.Controls.Add(this.lbl_number);
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
            // lbl_duration
            // 
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.Location = new System.Drawing.Point(754, 10);
            this.lbl_duration.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(140, 20);
            this.lbl_duration.TabIndex = 4;
            this.lbl_duration.Text = "CODE POSTAL";
            this.lbl_duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_deposit_date
            // 
            this.lbl_deposit_date.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deposit_date.Location = new System.Drawing.Point(608, 10);
            this.lbl_deposit_date.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_deposit_date.Name = "lbl_deposit_date";
            this.lbl_deposit_date.Size = new System.Drawing.Size(140, 20);
            this.lbl_deposit_date.TabIndex = 3;
            this.lbl_deposit_date.Text = "VILLE";
            this.lbl_deposit_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_company
            // 
            this.lbl_company.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company.Location = new System.Drawing.Point(306, 10);
            this.lbl_company.MaximumSize = new System.Drawing.Size(296, 20);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(296, 20);
            this.lbl_company.TabIndex = 2;
            this.lbl_company.Text = "SIEGE SOCIAL";
            this.lbl_company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_molecule
            // 
            this.lbl_molecule.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_molecule.Location = new System.Drawing.Point(160, 10);
            this.lbl_molecule.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_molecule.Name = "lbl_molecule";
            this.lbl_molecule.Size = new System.Drawing.Size(140, 20);
            this.lbl_molecule.TabIndex = 1;
            this.lbl_molecule.Text = "NOM";
            this.lbl_molecule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_number
            // 
            this.lbl_number.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(10, 10);
            this.lbl_number.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(140, 20);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "ID";
            // 
            // pnl_companies
            // 
            this.pnl_companies.AutoScroll = true;
            this.pnl_companies.Location = new System.Drawing.Point(55, 175);
            this.pnl_companies.Name = "pnl_companies";
            this.pnl_companies.Size = new System.Drawing.Size(1040, 546);
            this.pnl_companies.TabIndex = 3;
            // 
            // btn_orderby_name
            // 
            this.btn_orderby_name.AnimationHoverSpeed = 0.07F;
            this.btn_orderby_name.AnimationSpeed = 0.03F;
            this.btn_orderby_name.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderby_name.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_name.BorderColor = System.Drawing.Color.Black;
            this.btn_orderby_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orderby_name.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_orderby_name.FocusedColor = System.Drawing.Color.Empty;
            this.btn_orderby_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderby_name.ForeColor = System.Drawing.Color.White;
            this.btn_orderby_name.Image = null;
            this.btn_orderby_name.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_orderby_name.Location = new System.Drawing.Point(70, 81);
            this.btn_orderby_name.Name = "btn_orderby_name";
            this.btn_orderby_name.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_name.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_name.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_orderby_name.OnHoverImage = null;
            this.btn_orderby_name.OnPressedColor = System.Drawing.Color.Black;
            this.btn_orderby_name.Radius = 13;
            this.btn_orderby_name.Size = new System.Drawing.Size(140, 30);
            this.btn_orderby_name.TabIndex = 4;
            this.btn_orderby_name.Text = "NOM";
            this.btn_orderby_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_orderby_city
            // 
            this.btn_orderby_city.AnimationHoverSpeed = 0.07F;
            this.btn_orderby_city.AnimationSpeed = 0.03F;
            this.btn_orderby_city.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderby_city.BaseColor = System.Drawing.Color.White;
            this.btn_orderby_city.BorderColor = System.Drawing.Color.Black;
            this.btn_orderby_city.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orderby_city.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_orderby_city.FocusedColor = System.Drawing.Color.Empty;
            this.btn_orderby_city.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderby_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_orderby_city.Image = null;
            this.btn_orderby_city.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_orderby_city.Location = new System.Drawing.Point(216, 81);
            this.btn_orderby_city.Name = "btn_orderby_city";
            this.btn_orderby_city.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_city.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_city.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_orderby_city.OnHoverImage = null;
            this.btn_orderby_city.OnPressedColor = System.Drawing.Color.Black;
            this.btn_orderby_city.Radius = 13;
            this.btn_orderby_city.Size = new System.Drawing.Size(110, 30);
            this.btn_orderby_city.TabIndex = 5;
            this.btn_orderby_city.Text = "VILLE";
            this.btn_orderby_city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // btn_create_company
            // 
            this.btn_create_company.AnimationHoverSpeed = 0.07F;
            this.btn_create_company.AnimationSpeed = 0.03F;
            this.btn_create_company.BackColor = System.Drawing.Color.Transparent;
            this.btn_create_company.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_create_company.BorderColor = System.Drawing.Color.Black;
            this.btn_create_company.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_company.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_create_company.FocusedColor = System.Drawing.Color.Empty;
            this.btn_create_company.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_company.ForeColor = System.Drawing.Color.White;
            this.btn_create_company.Image = global::FrontEndGSBrevet.Properties.Resources.plus;
            this.btn_create_company.ImageSize = new System.Drawing.Size(12, 12);
            this.btn_create_company.Location = new System.Drawing.Point(878, 77);
            this.btn_create_company.Name = "btn_create_company";
            this.btn_create_company.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_create_company.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_create_company.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_create_company.OnHoverImage = null;
            this.btn_create_company.OnPressedColor = System.Drawing.Color.Black;
            this.btn_create_company.Radius = 6;
            this.btn_create_company.Size = new System.Drawing.Size(187, 42);
            this.btn_create_company.TabIndex = 7;
            this.btn_create_company.Text = "CREER UNE ENTREPRISE";
            this.btn_create_company.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_create_company.Click += new System.EventHandler(this.btn_create_company_Click);
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
            this.btn_refresh.Location = new System.Drawing.Point(817, 77);
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
            // uc_MainCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.btn_create_company);
            this.Controls.Add(this.btn_orderby_city);
            this.Controls.Add(this.btn_orderby_name);
            this.Controls.Add(this.pnl_companies);
            this.Controls.Add(this.pnl_tableHeader);
            this.Name = "uc_MainCompany";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_MainCompany_Load);
            this.pnl_tableHeader.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_tableHeader;
        private Guna.UI.WinForms.GunaLabel lbl_actions;
        private Guna.UI.WinForms.GunaLabel lbl_duration;
        private Guna.UI.WinForms.GunaLabel lbl_deposit_date;
        private Guna.UI.WinForms.GunaLabel lbl_company;
        private Guna.UI.WinForms.GunaLabel lbl_molecule;
        private Guna.UI.WinForms.GunaLabel lbl_number;
        private System.Windows.Forms.FlowLayoutPanel pnl_companies;
        private Guna.UI.WinForms.GunaButton btn_orderby_name;
        private Guna.UI.WinForms.GunaButton btn_orderby_city;
        private Guna.UI.WinForms.GunaButton btn_create_company;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaCircleButton btn_search;
        private Guna.UI.WinForms.GunaTextBox tbox_search;
        private Guna.UI.WinForms.GunaCircleButton btn_refresh;
    }
}
