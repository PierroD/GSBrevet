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
            this.lbl_title = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.btn_close = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnl_Menu = new Guna.UI.WinForms.GunaPanel();
            this.pnl_sideMenu = new Guna.UI.WinForms.GunaPanel();
            this.btn_menu = new Guna.UI.WinForms.GunaButton();
            this.btn_settings = new Guna.UI.WinForms.GunaButton();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.pnl_main = new Guna.UI.WinForms.GunaLinePanel();
            this.pnl_top.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.White;
            this.pnl_top.Controls.Add(this.gunaCircleButton1);
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.gunaControlBox1);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1400, 57);
            this.pnl_top.TabIndex = 0;
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
            this.gunaControlBox1.Location = new System.Drawing.Point(1287, 17);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 23);
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
            this.btn_close.Location = new System.Drawing.Point(1343, 17);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBackColor = System.Drawing.Color.Red;
            this.btn_close.OnHoverIconColor = System.Drawing.Color.White;
            this.btn_close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_close.Size = new System.Drawing.Size(45, 23);
            this.btn_close.TabIndex = 0;
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
            this.pnl_Menu.Controls.Add(this.btn_menu);
            this.pnl_Menu.Controls.Add(this.btn_settings);
            this.pnl_Menu.Location = new System.Drawing.Point(0, 57);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(60, 743);
            this.pnl_Menu.TabIndex = 1;
            // 
            // pnl_sideMenu
            // 
            this.pnl_sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.pnl_sideMenu.Location = new System.Drawing.Point(60, 63);
            this.pnl_sideMenu.Name = "pnl_sideMenu";
            this.pnl_sideMenu.Size = new System.Drawing.Size(200, 737);
            this.pnl_sideMenu.TabIndex = 2;
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
            this.btn_menu.OnHoverImage = null;
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
            this.btn_settings.OnHoverImage = null;
            this.btn_settings.OnPressedColor = System.Drawing.Color.Black;
            this.btn_settings.Size = new System.Drawing.Size(60, 42);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(1231, 3);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(50, 50);
            this.gunaCircleButton1.TabIndex = 3;
            this.gunaCircleButton1.Text = "PD";
            // 
            // pnl_main
            // 
            this.pnl_main.LineBottom = 3;
            this.pnl_main.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.pnl_main.LineLeft = 3;
            this.pnl_main.LineRight = 3;
            this.pnl_main.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_main.LineTop = 3;
            this.pnl_main.Location = new System.Drawing.Point(260, 63);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1140, 737);
            this.pnl_main.TabIndex = 3;
            // 
            // form_Public
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnl_main);
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
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaLinePanel pnl_main;
    }
}