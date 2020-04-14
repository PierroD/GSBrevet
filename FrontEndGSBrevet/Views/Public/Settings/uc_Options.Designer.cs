namespace FrontEndGSBrevet.Views.Public.Settings
{
    partial class uc_Options
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
            this.Pbox_uc_image = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lbl_uc_Title = new Guna.UI.WinForms.GunaLabel();
            this.lbl_LaunchWithWindowsTitle = new Guna.UI.WinForms.GunaLabel();
            this.lbl_LaunchWithWindowsDescription = new Guna.UI.WinForms.GunaLabel();
            this.lbl_LaunchWithWindowsSwitch = new Guna.UI.WinForms.GunaWinSwitch();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_EnableNotificationsSwitch = new Guna.UI.WinForms.GunaWinSwitch();
            this.lbl_EnableNotificationsDescription = new Guna.UI.WinForms.GunaLabel();
            this.lbl_EnableNotificationsTitle = new Guna.UI.WinForms.GunaLabel();
            this.lbl_LanguageDescription = new Guna.UI.WinForms.GunaLabel();
            this.lbl_LanguageTitle = new Guna.UI.WinForms.GunaLabel();
            this.rbtn_LanguageFR = new Guna.UI.WinForms.GunaAdvenceButton();
            this.rbtn_LanguageEN = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_uc_image)).BeginInit();
            this.SuspendLayout();
            // 
            // Pbox_uc_image
            // 
            this.Pbox_uc_image.BaseColor = System.Drawing.Color.Transparent;
            this.Pbox_uc_image.Image = global::FrontEndGSBrevet.Properties.Resources.options;
            this.Pbox_uc_image.Location = new System.Drawing.Point(3, 3);
            this.Pbox_uc_image.Name = "Pbox_uc_image";
            this.Pbox_uc_image.Size = new System.Drawing.Size(30, 30);
            this.Pbox_uc_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbox_uc_image.TabIndex = 0;
            this.Pbox_uc_image.TabStop = false;
            this.Pbox_uc_image.UseTransfarantBackground = false;
            // 
            // lbl_uc_Title
            // 
            this.lbl_uc_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uc_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_uc_Title.Location = new System.Drawing.Point(39, 3);
            this.lbl_uc_Title.Name = "lbl_uc_Title";
            this.lbl_uc_Title.Size = new System.Drawing.Size(90, 30);
            this.lbl_uc_Title.TabIndex = 1;
            this.lbl_uc_Title.Text = "Options";
            this.lbl_uc_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_LaunchWithWindowsTitle
            // 
            this.lbl_LaunchWithWindowsTitle.AutoSize = true;
            this.lbl_LaunchWithWindowsTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LaunchWithWindowsTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_LaunchWithWindowsTitle.Location = new System.Drawing.Point(121, 70);
            this.lbl_LaunchWithWindowsTitle.Name = "lbl_LaunchWithWindowsTitle";
            this.lbl_LaunchWithWindowsTitle.Size = new System.Drawing.Size(224, 30);
            this.lbl_LaunchWithWindowsTitle.TabIndex = 2;
            this.lbl_LaunchWithWindowsTitle.Text = "Lancer avec Windows";
            // 
            // lbl_LaunchWithWindowsDescription
            // 
            this.lbl_LaunchWithWindowsDescription.AutoSize = true;
            this.lbl_LaunchWithWindowsDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_LaunchWithWindowsDescription.ForeColor = System.Drawing.Color.Thistle;
            this.lbl_LaunchWithWindowsDescription.Location = new System.Drawing.Point(121, 130);
            this.lbl_LaunchWithWindowsDescription.Name = "lbl_LaunchWithWindowsDescription";
            this.lbl_LaunchWithWindowsDescription.Size = new System.Drawing.Size(322, 21);
            this.lbl_LaunchWithWindowsDescription.TabIndex = 3;
            this.lbl_LaunchWithWindowsDescription.Text = "Lancer GSBrevets au démarrage de Windows";
            // 
            // lbl_LaunchWithWindowsSwitch
            // 
            this.lbl_LaunchWithWindowsSwitch.BaseColor = System.Drawing.SystemColors.Control;
            this.lbl_LaunchWithWindowsSwitch.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.lbl_LaunchWithWindowsSwitch.CheckedOnColor = System.Drawing.Color.Thistle;
            this.lbl_LaunchWithWindowsSwitch.FillColor = System.Drawing.Color.White;
            this.lbl_LaunchWithWindowsSwitch.Location = new System.Drawing.Point(126, 183);
            this.lbl_LaunchWithWindowsSwitch.Name = "lbl_LaunchWithWindowsSwitch";
            this.lbl_LaunchWithWindowsSwitch.Size = new System.Drawing.Size(40, 22);
            this.lbl_LaunchWithWindowsSwitch.TabIndex = 6;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(120, 246);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(900, 10);
            this.gunaSeparator1.TabIndex = 7;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(120, 461);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(900, 10);
            this.gunaSeparator2.TabIndex = 11;
            // 
            // lbl_EnableNotificationsSwitch
            // 
            this.lbl_EnableNotificationsSwitch.BaseColor = System.Drawing.SystemColors.Control;
            this.lbl_EnableNotificationsSwitch.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.lbl_EnableNotificationsSwitch.CheckedOnColor = System.Drawing.Color.Thistle;
            this.lbl_EnableNotificationsSwitch.FillColor = System.Drawing.Color.White;
            this.lbl_EnableNotificationsSwitch.Location = new System.Drawing.Point(126, 398);
            this.lbl_EnableNotificationsSwitch.Name = "lbl_EnableNotificationsSwitch";
            this.lbl_EnableNotificationsSwitch.Size = new System.Drawing.Size(40, 22);
            this.lbl_EnableNotificationsSwitch.TabIndex = 10;
            // 
            // lbl_EnableNotificationsDescription
            // 
            this.lbl_EnableNotificationsDescription.AutoSize = true;
            this.lbl_EnableNotificationsDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_EnableNotificationsDescription.ForeColor = System.Drawing.Color.Thistle;
            this.lbl_EnableNotificationsDescription.Location = new System.Drawing.Point(121, 345);
            this.lbl_EnableNotificationsDescription.Name = "lbl_EnableNotificationsDescription";
            this.lbl_EnableNotificationsDescription.Size = new System.Drawing.Size(479, 21);
            this.lbl_EnableNotificationsDescription.TabIndex = 9;
            this.lbl_EnableNotificationsDescription.Text = "Vous serez notifié par GSBrevets lors de l\'ajout de nouveaux brevets";
            // 
            // lbl_EnableNotificationsTitle
            // 
            this.lbl_EnableNotificationsTitle.AutoSize = true;
            this.lbl_EnableNotificationsTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnableNotificationsTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_EnableNotificationsTitle.Location = new System.Drawing.Point(121, 285);
            this.lbl_EnableNotificationsTitle.Name = "lbl_EnableNotificationsTitle";
            this.lbl_EnableNotificationsTitle.Size = new System.Drawing.Size(244, 30);
            this.lbl_EnableNotificationsTitle.TabIndex = 8;
            this.lbl_EnableNotificationsTitle.Text = "Activer les notifications";
            // 
            // lbl_LanguageDescription
            // 
            this.lbl_LanguageDescription.AutoSize = true;
            this.lbl_LanguageDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_LanguageDescription.ForeColor = System.Drawing.Color.Thistle;
            this.lbl_LanguageDescription.Location = new System.Drawing.Point(121, 561);
            this.lbl_LanguageDescription.Name = "lbl_LanguageDescription";
            this.lbl_LanguageDescription.Size = new System.Drawing.Size(245, 21);
            this.lbl_LanguageDescription.TabIndex = 13;
            this.lbl_LanguageDescription.Text = "Choisissez la langue de GSBrevets";
            // 
            // lbl_LanguageTitle
            // 
            this.lbl_LanguageTitle.AutoSize = true;
            this.lbl_LanguageTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LanguageTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_LanguageTitle.Location = new System.Drawing.Point(121, 501);
            this.lbl_LanguageTitle.Name = "lbl_LanguageTitle";
            this.lbl_LanguageTitle.Size = new System.Drawing.Size(96, 30);
            this.lbl_LanguageTitle.TabIndex = 12;
            this.lbl_LanguageTitle.Text = "Langage";
            // 
            // rbtn_LanguageFR
            // 
            this.rbtn_LanguageFR.AnimationHoverSpeed = 0.07F;
            this.rbtn_LanguageFR.AnimationSpeed = 0.03F;
            this.rbtn_LanguageFR.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_LanguageFR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.rbtn_LanguageFR.BorderColor = System.Drawing.Color.Thistle;
            this.rbtn_LanguageFR.BorderSize = 2;
            this.rbtn_LanguageFR.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.rbtn_LanguageFR.Checked = true;
            this.rbtn_LanguageFR.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.rbtn_LanguageFR.CheckedBorderColor = System.Drawing.Color.Thistle;
            this.rbtn_LanguageFR.CheckedForeColor = System.Drawing.Color.White;
            this.rbtn_LanguageFR.CheckedImage = null;
            this.rbtn_LanguageFR.CheckedLineColor = System.Drawing.Color.DimGray;
            this.rbtn_LanguageFR.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rbtn_LanguageFR.FocusedColor = System.Drawing.Color.Empty;
            this.rbtn_LanguageFR.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_LanguageFR.ForeColor = System.Drawing.Color.White;
            this.rbtn_LanguageFR.Image = null;
            this.rbtn_LanguageFR.ImageSize = new System.Drawing.Size(20, 20);
            this.rbtn_LanguageFR.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_LanguageFR.Location = new System.Drawing.Point(120, 614);
            this.rbtn_LanguageFR.Name = "rbtn_LanguageFR";
            this.rbtn_LanguageFR.OnHoverBaseColor = System.Drawing.Color.White;
            this.rbtn_LanguageFR.OnHoverBorderColor = System.Drawing.Color.Thistle;
            this.rbtn_LanguageFR.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.rbtn_LanguageFR.OnHoverImage = null;
            this.rbtn_LanguageFR.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_LanguageFR.OnPressedColor = System.Drawing.Color.Black;
            this.rbtn_LanguageFR.Radius = 6;
            this.rbtn_LanguageFR.Size = new System.Drawing.Size(100, 42);
            this.rbtn_LanguageFR.TabIndex = 14;
            this.rbtn_LanguageFR.Text = "FR";
            this.rbtn_LanguageFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtn_LanguageEN
            // 
            this.rbtn_LanguageEN.AnimationHoverSpeed = 0.07F;
            this.rbtn_LanguageEN.AnimationSpeed = 0.03F;
            this.rbtn_LanguageEN.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_LanguageEN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.rbtn_LanguageEN.BorderColor = System.Drawing.Color.Thistle;
            this.rbtn_LanguageEN.BorderSize = 2;
            this.rbtn_LanguageEN.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.rbtn_LanguageEN.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.rbtn_LanguageEN.CheckedBorderColor = System.Drawing.Color.Thistle;
            this.rbtn_LanguageEN.CheckedForeColor = System.Drawing.Color.White;
            this.rbtn_LanguageEN.CheckedImage = null;
            this.rbtn_LanguageEN.CheckedLineColor = System.Drawing.Color.DimGray;
            this.rbtn_LanguageEN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rbtn_LanguageEN.FocusedColor = System.Drawing.Color.Empty;
            this.rbtn_LanguageEN.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_LanguageEN.ForeColor = System.Drawing.Color.White;
            this.rbtn_LanguageEN.Image = null;
            this.rbtn_LanguageEN.ImageSize = new System.Drawing.Size(20, 20);
            this.rbtn_LanguageEN.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_LanguageEN.Location = new System.Drawing.Point(220, 614);
            this.rbtn_LanguageEN.Name = "rbtn_LanguageEN";
            this.rbtn_LanguageEN.OnHoverBaseColor = System.Drawing.Color.White;
            this.rbtn_LanguageEN.OnHoverBorderColor = System.Drawing.Color.Thistle;
            this.rbtn_LanguageEN.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.rbtn_LanguageEN.OnHoverImage = null;
            this.rbtn_LanguageEN.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_LanguageEN.OnPressedColor = System.Drawing.Color.Black;
            this.rbtn_LanguageEN.Radius = 6;
            this.rbtn_LanguageEN.Size = new System.Drawing.Size(100, 42);
            this.rbtn_LanguageEN.TabIndex = 15;
            this.rbtn_LanguageEN.Text = "EN";
            this.rbtn_LanguageEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uc_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.rbtn_LanguageEN);
            this.Controls.Add(this.rbtn_LanguageFR);
            this.Controls.Add(this.lbl_LanguageDescription);
            this.Controls.Add(this.lbl_LanguageTitle);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.lbl_EnableNotificationsSwitch);
            this.Controls.Add(this.lbl_EnableNotificationsDescription);
            this.Controls.Add(this.lbl_EnableNotificationsTitle);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.lbl_LaunchWithWindowsSwitch);
            this.Controls.Add(this.lbl_LaunchWithWindowsDescription);
            this.Controls.Add(this.lbl_LaunchWithWindowsTitle);
            this.Controls.Add(this.lbl_uc_Title);
            this.Controls.Add(this.Pbox_uc_image);
            this.Name = "uc_Options";
            this.Size = new System.Drawing.Size(1140, 737);
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_uc_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox Pbox_uc_image;
        private Guna.UI.WinForms.GunaLabel lbl_uc_Title;
        private Guna.UI.WinForms.GunaLabel lbl_LaunchWithWindowsTitle;
        private Guna.UI.WinForms.GunaLabel lbl_LaunchWithWindowsDescription;
        private Guna.UI.WinForms.GunaWinSwitch lbl_LaunchWithWindowsSwitch;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaWinSwitch lbl_EnableNotificationsSwitch;
        private Guna.UI.WinForms.GunaLabel lbl_EnableNotificationsDescription;
        private Guna.UI.WinForms.GunaLabel lbl_EnableNotificationsTitle;
        private Guna.UI.WinForms.GunaLabel lbl_LanguageDescription;
        private Guna.UI.WinForms.GunaLabel lbl_LanguageTitle;
        private Guna.UI.WinForms.GunaAdvenceButton rbtn_LanguageFR;
        private Guna.UI.WinForms.GunaAdvenceButton rbtn_LanguageEN;
    }
}
