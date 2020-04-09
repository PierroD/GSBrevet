namespace FrontEndGSBrevet.Views.Admin.Users
{
    partial class uc_MainUser
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
            this.lbl_birthDate = new Guna.UI.WinForms.GunaLabel();
            this.lbl_username = new Guna.UI.WinForms.GunaLabel();
            this.lbl_firstName = new Guna.UI.WinForms.GunaLabel();
            this.lbl_lastName = new Guna.UI.WinForms.GunaLabel();
            this.lbl_id = new Guna.UI.WinForms.GunaLabel();
            this.pnl_users = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_orderby_firstName = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_orderby_lastName = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.tbox_search = new Guna.UI.WinForms.GunaTextBox();
            this.btn_search = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_orderby_username = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_refresh = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_create_user = new Guna.UI.WinForms.GunaButton();
            this.pnl_tableHeader.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_tableHeader
            // 
            this.pnl_tableHeader.Controls.Add(this.lbl_actions);
            this.pnl_tableHeader.Controls.Add(this.lbl_birthDate);
            this.pnl_tableHeader.Controls.Add(this.lbl_username);
            this.pnl_tableHeader.Controls.Add(this.lbl_firstName);
            this.pnl_tableHeader.Controls.Add(this.lbl_lastName);
            this.pnl_tableHeader.Controls.Add(this.lbl_id);
            this.pnl_tableHeader.Location = new System.Drawing.Point(55, 122);
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
            // lbl_birthDate
            // 
            this.lbl_birthDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthDate.Location = new System.Drawing.Point(694, 10);
            this.lbl_birthDate.MaximumSize = new System.Drawing.Size(200, 20);
            this.lbl_birthDate.Name = "lbl_birthDate";
            this.lbl_birthDate.Size = new System.Drawing.Size(200, 20);
            this.lbl_birthDate.TabIndex = 4;
            this.lbl_birthDate.Text = "ROLE";
            this.lbl_birthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(492, 10);
            this.lbl_username.MaximumSize = new System.Drawing.Size(190, 20);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(190, 20);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "IDENTIFIANT";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.Location = new System.Drawing.Point(326, 10);
            this.lbl_firstName.MaximumSize = new System.Drawing.Size(160, 20);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(160, 20);
            this.lbl_firstName.TabIndex = 2;
            this.lbl_firstName.Text = "PRENOM";
            this.lbl_firstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.Location = new System.Drawing.Point(160, 10);
            this.lbl_lastName.MaximumSize = new System.Drawing.Size(160, 20);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(160, 20);
            this.lbl_lastName.TabIndex = 1;
            this.lbl_lastName.Text = "NOM";
            this.lbl_lastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pnl_users
            // 
            this.pnl_users.AutoScroll = true;
            this.pnl_users.Location = new System.Drawing.Point(55, 168);
            this.pnl_users.Name = "pnl_users";
            this.pnl_users.Size = new System.Drawing.Size(1040, 554);
            this.pnl_users.TabIndex = 3;
            // 
            // btn_orderby_firstName
            // 
            this.btn_orderby_firstName.AnimationHoverSpeed = 0.07F;
            this.btn_orderby_firstName.AnimationSpeed = 0.03F;
            this.btn_orderby_firstName.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderby_firstName.BaseColor = System.Drawing.Color.White;
            this.btn_orderby_firstName.BorderColor = System.Drawing.Color.Black;
            this.btn_orderby_firstName.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_orderby_firstName.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_firstName.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_firstName.CheckedForeColor = System.Drawing.Color.White;
            this.btn_orderby_firstName.CheckedImage = null;
            this.btn_orderby_firstName.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_firstName.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_orderby_firstName.FocusedColor = System.Drawing.Color.Empty;
            this.btn_orderby_firstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderby_firstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_firstName.Image = null;
            this.btn_orderby_firstName.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_orderby_firstName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_firstName.Location = new System.Drawing.Point(201, 70);
            this.btn_orderby_firstName.Name = "btn_orderby_firstName";
            this.btn_orderby_firstName.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_firstName.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_firstName.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_orderby_firstName.OnHoverImage = null;
            this.btn_orderby_firstName.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_firstName.OnPressedColor = System.Drawing.Color.Black;
            this.btn_orderby_firstName.Radius = 13;
            this.btn_orderby_firstName.Size = new System.Drawing.Size(140, 30);
            this.btn_orderby_firstName.TabIndex = 15;
            this.btn_orderby_firstName.Text = "PRENOM";
            this.btn_orderby_firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_orderby_lastName
            // 
            this.btn_orderby_lastName.AnimationHoverSpeed = 0.07F;
            this.btn_orderby_lastName.AnimationSpeed = 0.03F;
            this.btn_orderby_lastName.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderby_lastName.BaseColor = System.Drawing.Color.White;
            this.btn_orderby_lastName.BorderColor = System.Drawing.Color.Black;
            this.btn_orderby_lastName.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_orderby_lastName.Checked = true;
            this.btn_orderby_lastName.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_lastName.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_lastName.CheckedForeColor = System.Drawing.Color.White;
            this.btn_orderby_lastName.CheckedImage = null;
            this.btn_orderby_lastName.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_lastName.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_orderby_lastName.FocusedColor = System.Drawing.Color.Empty;
            this.btn_orderby_lastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderby_lastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_lastName.Image = null;
            this.btn_orderby_lastName.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_orderby_lastName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_lastName.Location = new System.Drawing.Point(55, 70);
            this.btn_orderby_lastName.Name = "btn_orderby_lastName";
            this.btn_orderby_lastName.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_lastName.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_lastName.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_orderby_lastName.OnHoverImage = null;
            this.btn_orderby_lastName.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_lastName.OnPressedColor = System.Drawing.Color.Black;
            this.btn_orderby_lastName.Radius = 13;
            this.btn_orderby_lastName.Size = new System.Drawing.Size(140, 30);
            this.btn_orderby_lastName.TabIndex = 16;
            this.btn_orderby_lastName.Text = "NOM";
            this.btn_orderby_lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.tbox_search);
            this.gunaShadowPanel1.Controls.Add(this.btn_search);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(55, 5);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1040, 50);
            this.gunaShadowPanel1.TabIndex = 17;
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
            this.tbox_search.Enter += new System.EventHandler(this.tbox_search_Enter);
            this.tbox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_search_KeyPress);
            this.tbox_search.Leave += new System.EventHandler(this.tbox_search_Leave);
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
            this.btn_search.Image = global::FrontEndGSBrevet.Properties.Resources.search_admin;
            this.btn_search.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_search.Location = new System.Drawing.Point(19, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_search.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_search.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.search_on;
            this.btn_search.OnPressedColor = System.Drawing.Color.Black;
            this.btn_search.Size = new System.Drawing.Size(40, 40);
            this.btn_search.TabIndex = 0;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_orderby_username
            // 
            this.btn_orderby_username.AnimationHoverSpeed = 0.07F;
            this.btn_orderby_username.AnimationSpeed = 0.03F;
            this.btn_orderby_username.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderby_username.BaseColor = System.Drawing.Color.White;
            this.btn_orderby_username.BorderColor = System.Drawing.Color.Black;
            this.btn_orderby_username.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_orderby_username.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_username.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_username.CheckedForeColor = System.Drawing.Color.White;
            this.btn_orderby_username.CheckedImage = null;
            this.btn_orderby_username.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_username.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_orderby_username.FocusedColor = System.Drawing.Color.Empty;
            this.btn_orderby_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderby_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_username.Image = null;
            this.btn_orderby_username.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_orderby_username.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_username.Location = new System.Drawing.Point(347, 70);
            this.btn_orderby_username.Name = "btn_orderby_username";
            this.btn_orderby_username.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_orderby_username.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_orderby_username.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_orderby_username.OnHoverImage = null;
            this.btn_orderby_username.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_orderby_username.OnPressedColor = System.Drawing.Color.Black;
            this.btn_orderby_username.Radius = 13;
            this.btn_orderby_username.Size = new System.Drawing.Size(140, 30);
            this.btn_orderby_username.TabIndex = 19;
            this.btn_orderby_username.Text = "IDENTIFIANT";
            this.btn_orderby_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btn_refresh.Image = global::FrontEndGSBrevet.Properties.Resources.refresh_admin;
            this.btn_refresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_refresh.Location = new System.Drawing.Point(820, 70);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_refresh.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.refresh_on;
            this.btn_refresh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_refresh.Size = new System.Drawing.Size(42, 42);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_create_user
            // 
            this.btn_create_user.AnimationHoverSpeed = 0.07F;
            this.btn_create_user.AnimationSpeed = 0.03F;
            this.btn_create_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_create_user.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_create_user.BorderColor = System.Drawing.Color.Black;
            this.btn_create_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_user.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_create_user.FocusedColor = System.Drawing.Color.Empty;
            this.btn_create_user.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_user.ForeColor = System.Drawing.Color.White;
            this.btn_create_user.Image = global::FrontEndGSBrevet.Properties.Resources.plus;
            this.btn_create_user.ImageSize = new System.Drawing.Size(12, 12);
            this.btn_create_user.Location = new System.Drawing.Point(881, 70);
            this.btn_create_user.Name = "btn_create_user";
            this.btn_create_user.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_create_user.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_create_user.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_create_user.OnHoverImage = null;
            this.btn_create_user.OnPressedColor = System.Drawing.Color.Black;
            this.btn_create_user.Radius = 6;
            this.btn_create_user.Size = new System.Drawing.Size(184, 42);
            this.btn_create_user.TabIndex = 7;
            this.btn_create_user.Text = "CREER UN UTILISATEUR";
            this.btn_create_user.Click += new System.EventHandler(this.btn_create_user_Click);
            // 
            // uc_MainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_orderby_username);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.btn_orderby_lastName);
            this.Controls.Add(this.btn_orderby_firstName);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_create_user);
            this.Controls.Add(this.pnl_users);
            this.Controls.Add(this.pnl_tableHeader);
            this.Name = "uc_MainUser";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_MainUser_Load);
            this.pnl_tableHeader.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_tableHeader;
        private Guna.UI.WinForms.GunaLabel lbl_actions;
        private Guna.UI.WinForms.GunaLabel lbl_birthDate;
        private Guna.UI.WinForms.GunaLabel lbl_username;
        private Guna.UI.WinForms.GunaLabel lbl_firstName;
        private Guna.UI.WinForms.GunaLabel lbl_lastName;
        private Guna.UI.WinForms.GunaLabel lbl_id;
        private System.Windows.Forms.FlowLayoutPanel pnl_users;
        private Guna.UI.WinForms.GunaButton btn_create_user;
        private Guna.UI.WinForms.GunaCircleButton btn_refresh;
        private Guna.UI.WinForms.GunaAdvenceButton btn_orderby_firstName;
        private Guna.UI.WinForms.GunaAdvenceButton btn_orderby_lastName;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaTextBox tbox_search;
        private Guna.UI.WinForms.GunaCircleButton btn_search;
        private Guna.UI.WinForms.GunaAdvenceButton btn_orderby_username;

    }
}
