namespace FrontEndGSBrevet.Views.Admin
{
    partial class form_Admin
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
            this.pnl_top = new Guna.UI.WinForms.GunaPanel();
            this.lbl_userType = new Guna.UI.WinForms.GunaLabel();
            this.btn_initial = new Guna.UI.WinForms.GunaCircleButton();
            this.lbl_title = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.btn_close = new Guna.UI.WinForms.GunaControlBox();
            this.btn_orderby_username = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_search = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_refresh = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_create_contract = new Guna.UI.WinForms.GunaButton();
            this.pnl_tableHeader.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.pnl_top.SuspendLayout();
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
            this.pnl_tableHeader.Location = new System.Drawing.Point(55, 196);
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
            this.lbl_birthDate.Text = "DATE DE NAISSANCE";
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
            this.pnl_users.Location = new System.Drawing.Point(55, 242);
            this.pnl_users.Name = "pnl_users";
            this.pnl_users.Size = new System.Drawing.Size(1040, 546);
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
            this.btn_orderby_firstName.Location = new System.Drawing.Point(201, 144);
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
            this.btn_orderby_lastName.Location = new System.Drawing.Point(55, 144);
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
            this.gunaShadowPanel1.Location = new System.Drawing.Point(55, 79);
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
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.White;
            this.pnl_top.Controls.Add(this.lbl_userType);
            this.pnl_top.Controls.Add(this.btn_initial);
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.gunaControlBox1);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1140, 57);
            this.pnl_top.TabIndex = 18;
            // 
            // lbl_userType
            // 
            this.lbl_userType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_userType.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_userType.Location = new System.Drawing.Point(0, 37);
            this.lbl_userType.Name = "lbl_userType";
            this.lbl_userType.Size = new System.Drawing.Size(146, 17);
            this.lbl_userType.TabIndex = 4;
            this.lbl_userType.Text = "Administrateur";
            this.lbl_userType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_initial
            // 
            this.btn_initial.AnimationHoverSpeed = 0.07F;
            this.btn_initial.AnimationSpeed = 0.03F;
            this.btn_initial.BackColor = System.Drawing.Color.Transparent;
            this.btn_initial.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_initial.BorderColor = System.Drawing.Color.Black;
            this.btn_initial.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_initial.FocusedColor = System.Drawing.Color.Empty;
            this.btn_initial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_initial.ForeColor = System.Drawing.Color.White;
            this.btn_initial.Image = null;
            this.btn_initial.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_initial.Location = new System.Drawing.Point(1231, 3);
            this.btn_initial.Margin = new System.Windows.Forms.Padding(0);
            this.btn_initial.Name = "btn_initial";
            this.btn_initial.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_initial.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_initial.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_initial.OnHoverImage = null;
            this.btn_initial.OnPressedColor = System.Drawing.Color.Black;
            this.btn_initial.Size = new System.Drawing.Size(50, 50);
            this.btn_initial.TabIndex = 3;
            this.btn_initial.Text = "PD";
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(146, 54);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "GSBrevets";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.White;
            this.gunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1027, 8);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 40);
            this.gunaControlBox1.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.IconSize = 15F;
            this.btn_close.Location = new System.Drawing.Point(1083, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBackColor = System.Drawing.Color.Red;
            this.btn_close.OnHoverIconColor = System.Drawing.Color.White;
            this.btn_close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_close.Size = new System.Drawing.Size(45, 40);
            this.btn_close.TabIndex = 0;
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
            this.btn_orderby_username.Location = new System.Drawing.Point(347, 144);
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
            this.btn_refresh.Location = new System.Drawing.Point(820, 144);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_refresh.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.refresh_on;
            this.btn_refresh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_refresh.Size = new System.Drawing.Size(42, 42);
            this.btn_refresh.TabIndex = 10;
            // 
            // btn_create_contract
            // 
            this.btn_create_contract.AnimationHoverSpeed = 0.07F;
            this.btn_create_contract.AnimationSpeed = 0.03F;
            this.btn_create_contract.BackColor = System.Drawing.Color.Transparent;
            this.btn_create_contract.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_create_contract.BorderColor = System.Drawing.Color.Black;
            this.btn_create_contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_contract.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_create_contract.FocusedColor = System.Drawing.Color.Empty;
            this.btn_create_contract.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_contract.ForeColor = System.Drawing.Color.White;
            this.btn_create_contract.Image = global::FrontEndGSBrevet.Properties.Resources.plus;
            this.btn_create_contract.ImageSize = new System.Drawing.Size(12, 12);
            this.btn_create_contract.Location = new System.Drawing.Point(881, 144);
            this.btn_create_contract.Name = "btn_create_contract";
            this.btn_create_contract.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_create_contract.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_create_contract.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_create_contract.OnHoverImage = null;
            this.btn_create_contract.OnPressedColor = System.Drawing.Color.Black;
            this.btn_create_contract.Radius = 6;
            this.btn_create_contract.Size = new System.Drawing.Size(184, 42);
            this.btn_create_contract.TabIndex = 7;
            this.btn_create_contract.Text = "CREER UN UTILISATEUR";
            // 
            // form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 800);
            this.Controls.Add(this.btn_orderby_username);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.btn_orderby_lastName);
            this.Controls.Add(this.btn_orderby_firstName);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_create_contract);
            this.Controls.Add(this.pnl_users);
            this.Controls.Add(this.pnl_tableHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Admin";
            this.Text = "form_Admin";
            this.Load += new System.EventHandler(this.form_Admin_Load);
            this.pnl_tableHeader.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
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
        private Guna.UI.WinForms.GunaButton btn_create_contract;
        private Guna.UI.WinForms.GunaCircleButton btn_refresh;
        private Guna.UI.WinForms.GunaAdvenceButton btn_orderby_firstName;
        private Guna.UI.WinForms.GunaAdvenceButton btn_orderby_lastName;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaTextBox tbox_search;
        private Guna.UI.WinForms.GunaCircleButton btn_search;
        private Guna.UI.WinForms.GunaPanel pnl_top;
        private Guna.UI.WinForms.GunaLabel lbl_userType;
        private Guna.UI.WinForms.GunaCircleButton btn_initial;
        private Guna.UI.WinForms.GunaLabel lbl_title;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox btn_close;
        private Guna.UI.WinForms.GunaAdvenceButton btn_orderby_username;
    }
}