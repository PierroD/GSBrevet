namespace FrontEndGSBrevet.Views.Shared.SettingsMenu
{
    partial class uc_MainSettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_MainSettingsMenu));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_title = new Guna.UI.WinForms.GunaLabel();
            this.pnl_gradientDown = new Guna.UI.WinForms.GunaGradientPanel();
            this.pbox_waveDown = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.pbox_waveUp = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.pnl_gradientDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_waveDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_waveUp)).BeginInit();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(0, 356);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(1140, 156);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Avec l\'aide de ce menu vous allez pourvoir :\r\n- Afficher votre profil\r\n- Avoir ac" +
    "cès aux options (changer la langue, activer les notifications, lancer GSBrevets " +
    "au démarrage de Windows)";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 309);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1140, 32);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "Menu des paramètres";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_gradientDown
            // 
            this.pnl_gradientDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_gradientDown.BackgroundImage")));
            this.pnl_gradientDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_gradientDown.Controls.Add(this.pbox_waveDown);
            this.pnl_gradientDown.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.pnl_gradientDown.GradientColor2 = System.Drawing.Color.White;
            this.pnl_gradientDown.GradientColor3 = System.Drawing.Color.White;
            this.pnl_gradientDown.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.pnl_gradientDown.Location = new System.Drawing.Point(0, 550);
            this.pnl_gradientDown.Name = "pnl_gradientDown";
            this.pnl_gradientDown.Size = new System.Drawing.Size(1140, 187);
            this.pnl_gradientDown.TabIndex = 15;
            this.pnl_gradientDown.Text = "gunaGradientPanel2";
            // 
            // pbox_waveDown
            // 
            this.pbox_waveDown.BackColor = System.Drawing.Color.Transparent;
            this.pbox_waveDown.BaseColor = System.Drawing.Color.Black;
            this.pbox_waveDown.Image = global::FrontEndGSBrevet.Properties.Resources.wave_up;
            this.pbox_waveDown.Location = new System.Drawing.Point(0, 0);
            this.pbox_waveDown.Name = "pbox_waveDown";
            this.pbox_waveDown.Size = new System.Drawing.Size(1140, 167);
            this.pbox_waveDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_waveDown.TabIndex = 4;
            this.pbox_waveDown.TabStop = false;
            // 
            // pbox_waveUp
            // 
            this.pbox_waveUp.BackColor = System.Drawing.Color.Transparent;
            this.pbox_waveUp.BaseColor = System.Drawing.Color.Black;
            this.pbox_waveUp.Image = global::FrontEndGSBrevet.Properties.Resources.wave_down;
            this.pbox_waveUp.Location = new System.Drawing.Point(0, -32);
            this.pbox_waveUp.Name = "pbox_waveUp";
            this.pbox_waveUp.Size = new System.Drawing.Size(1140, 215);
            this.pbox_waveUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_waveUp.TabIndex = 16;
            this.pbox_waveUp.TabStop = false;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.pbox_waveUp);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(1140, 183);
            this.gunaGradientPanel1.TabIndex = 17;
            this.gunaGradientPanel1.Text = "gunaGradientPanel2";
            // 
            // uc_MainSettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.pnl_gradientDown);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.lbl_title);
            this.Name = "uc_MainSettingsMenu";
            this.Size = new System.Drawing.Size(1140, 737);
            this.pnl_gradientDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_waveDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_waveUp)).EndInit();
            this.gunaGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lbl_title;
        private Guna.UI.WinForms.GunaGradientPanel pnl_gradientDown;
        private Guna.UI.WinForms.GunaTransfarantPictureBox pbox_waveDown;
        private Guna.UI.WinForms.GunaTransfarantPictureBox pbox_waveUp;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;

    }
}
