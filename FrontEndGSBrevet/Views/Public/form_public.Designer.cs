namespace FrontEndGSBrevet.Views.Public
{
    partial class form_Public
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
            this.components = new System.ComponentModel.Container();
            this.pnl_top = new Guna.UI.WinForms.GunaPanel();
            this.lbl_userType = new Guna.UI.WinForms.GunaLabel();
            this.btn_initial = new Guna.UI.WinForms.GunaCircleButton();
            this.lbl_title = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.btn_close = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnl_Menu = new Guna.UI.WinForms.GunaPanel();
            this.btn_analytics = new Guna.UI.WinForms.GunaButton();
            this.btn_add = new Guna.UI.WinForms.GunaButton();
            this.btn_menu = new Guna.UI.WinForms.GunaButton();
            this.btn_settings = new Guna.UI.WinForms.GunaButton();
            this.pnl_sideMenu = new Guna.UI.WinForms.GunaPanel();
            pnl_main = new Guna.UI.WinForms.GunaLinePanel();
            this.pnl_top.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
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
            this.pnl_top.Size = new System.Drawing.Size(1400, 57);
            this.pnl_top.TabIndex = 0;
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
            this.lbl_userType.Text = "Utilisateur";
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
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
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
            this.gunaControlBox1.Location = new System.Drawing.Point(1287, 8);
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
            this.btn_close.Location = new System.Drawing.Point(1343, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBackColor = System.Drawing.Color.Red;
            this.btn_close.OnHoverIconColor = System.Drawing.Color.White;
            this.btn_close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_close.Size = new System.Drawing.Size(45, 40);
            this.btn_close.TabIndex = 0;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.pnl_top;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.White;
            this.pnl_Menu.Controls.Add(this.btn_analytics);
            this.pnl_Menu.Controls.Add(this.btn_add);
            this.pnl_Menu.Controls.Add(this.btn_menu);
            this.pnl_Menu.Controls.Add(this.btn_settings);
            this.pnl_Menu.Location = new System.Drawing.Point(0, 57);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(60, 743);
            this.pnl_Menu.TabIndex = 1;
            // 
            // btn_analytics
            // 
            this.btn_analytics.AnimationHoverSpeed = 0.07F;
            this.btn_analytics.AnimationSpeed = 0.03F;
            this.btn_analytics.BaseColor = System.Drawing.Color.White;
            this.btn_analytics.BorderColor = System.Drawing.Color.Black;
            this.btn_analytics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_analytics.FocusedColor = System.Drawing.Color.Empty;
            this.btn_analytics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_analytics.ForeColor = System.Drawing.Color.White;
            this.btn_analytics.Image = global::FrontEndGSBrevet.Properties.Resources.analytics_off;
            this.btn_analytics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_analytics.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_analytics.Location = new System.Drawing.Point(0, 102);
            this.btn_analytics.Name = "btn_analytics";
            this.btn_analytics.OnHoverBaseColor = System.Drawing.SystemColors.ControlLight;
            this.btn_analytics.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_analytics.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_analytics.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.analytics_off;
            this.btn_analytics.OnPressedColor = System.Drawing.Color.Black;
            this.btn_analytics.Size = new System.Drawing.Size(60, 42);
            this.btn_analytics.TabIndex = 3;
            this.btn_analytics.Click += new System.EventHandler(this.btn_analytics_Click);
            // 
            // btn_add
            // 
            this.btn_add.AnimationHoverSpeed = 0.07F;
            this.btn_add.AnimationSpeed = 0.03F;
            this.btn_add.BaseColor = System.Drawing.Color.White;
            this.btn_add.BorderColor = System.Drawing.Color.Black;
            this.btn_add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = global::FrontEndGSBrevet.Properties.Resources.add_off;
            this.btn_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_add.Location = new System.Drawing.Point(0, 54);
            this.btn_add.Name = "btn_add";
            this.btn_add.OnHoverBaseColor = System.Drawing.SystemColors.ControlLight;
            this.btn_add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_add.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_add.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.add_off;
            this.btn_add.OnPressedColor = System.Drawing.Color.Black;
            this.btn_add.Size = new System.Drawing.Size(60, 42);
            this.btn_add.TabIndex = 2;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.AnimationHoverSpeed = 0.07F;
            this.btn_menu.AnimationSpeed = 0.03F;
            this.btn_menu.BaseColor = System.Drawing.Color.White;
            this.btn_menu.BorderColor = System.Drawing.Color.Black;
            this.btn_menu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_menu.FocusedColor = System.Drawing.Color.Empty;
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = global::FrontEndGSBrevet.Properties.Resources.menu_off;
            this.btn_menu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_menu.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_menu.Location = new System.Drawing.Point(0, 6);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.OnHoverBaseColor = System.Drawing.SystemColors.ControlLight;
            this.btn_menu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_menu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_menu.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.menu_off;
            this.btn_menu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_menu.Size = new System.Drawing.Size(60, 42);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.AnimationHoverSpeed = 0.07F;
            this.btn_settings.AnimationSpeed = 0.03F;
            this.btn_settings.BaseColor = System.Drawing.Color.White;
            this.btn_settings.BorderColor = System.Drawing.Color.Black;
            this.btn_settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_settings.FocusedColor = System.Drawing.Color.Empty;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = global::FrontEndGSBrevet.Properties.Resources.settings_off;
            this.btn_settings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_settings.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_settings.Location = new System.Drawing.Point(0, 701);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.OnHoverBaseColor = System.Drawing.SystemColors.ControlLight;
            this.btn_settings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_settings.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_settings.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.settings_off;
            this.btn_settings.OnPressedColor = System.Drawing.Color.Black;
            this.btn_settings.Size = new System.Drawing.Size(60, 42);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // pnl_sideMenu
            // 
            this.pnl_sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.pnl_sideMenu.Location = new System.Drawing.Point(60, 63);
            this.pnl_sideMenu.Name = "pnl_sideMenu";
            this.pnl_sideMenu.Size = new System.Drawing.Size(200, 737);
            this.pnl_sideMenu.TabIndex = 2;
            // 
            // pnl_main
            // 
            pnl_main.LineBottom = 3;
            pnl_main.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            pnl_main.LineLeft = 3;
            pnl_main.LineStyle = System.Windows.Forms.BorderStyle.None;
            pnl_main.LineTop = 3;
            pnl_main.Location = new System.Drawing.Point(260, 63);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new System.Drawing.Size(1140, 737);
            pnl_main.TabIndex = 3;
            // 
            // form_Public
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(pnl_main);
            this.Controls.Add(this.pnl_sideMenu);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Public";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_public";
            this.pnl_top.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_top;
        private Guna.UI.WinForms.GunaControlBox btn_close;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel pnl_Menu;
        private Guna.UI.WinForms.GunaLabel lbl_title;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaPanel pnl_sideMenu;
        private Guna.UI.WinForms.GunaButton btn_settings;
        private Guna.UI.WinForms.GunaButton btn_menu;
        private Guna.UI.WinForms.GunaCircleButton btn_initial;
        private Guna.UI.WinForms.GunaButton btn_add;
        private Guna.UI.WinForms.GunaButton btn_analytics;
        private Guna.UI.WinForms.GunaLabel lbl_userType;
        public static Guna.UI.WinForms.GunaLinePanel pnl_main;
    }
}