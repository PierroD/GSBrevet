namespace FrontEndGSBrevet.Views.Shared
{
    partial class uc_SettingsMenu
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
            this.btn_profil = new Guna.UI.WinForms.GunaButton();
            this.btn_options = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // btn_profil
            // 
            this.btn_profil.AnimationHoverSpeed = 0.07F;
            this.btn_profil.AnimationSpeed = 0.03F;
            this.btn_profil.BackColor = System.Drawing.Color.Transparent;
            this.btn_profil.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_profil.BorderColor = System.Drawing.Color.Black;
            this.btn_profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_profil.FocusedColor = System.Drawing.Color.Empty;
            this.btn_profil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profil.ForeColor = System.Drawing.Color.White;
            this.btn_profil.Image = global::FrontEndGSBrevet.Properties.Resources.user;
            this.btn_profil.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_profil.Location = new System.Drawing.Point(3, 63);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_profil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_profil.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_profil.OnHoverImage = null;
            this.btn_profil.OnPressedColor = System.Drawing.Color.Black;
            this.btn_profil.Radius = 5;
            this.btn_profil.Size = new System.Drawing.Size(194, 42);
            this.btn_profil.TabIndex = 3;
            this.btn_profil.Text = "Profil";
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // btn_options
            // 
            this.btn_options.AnimationHoverSpeed = 0.07F;
            this.btn_options.AnimationSpeed = 0.03F;
            this.btn_options.BackColor = System.Drawing.Color.Transparent;
            this.btn_options.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_options.BorderColor = System.Drawing.Color.Black;
            this.btn_options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_options.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_options.FocusedColor = System.Drawing.Color.Empty;
            this.btn_options.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_options.ForeColor = System.Drawing.Color.White;
            this.btn_options.Image = global::FrontEndGSBrevet.Properties.Resources.options;
            this.btn_options.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_options.Location = new System.Drawing.Point(3, 3);
            this.btn_options.Name = "btn_options";
            this.btn_options.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_options.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_options.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_options.OnHoverImage = null;
            this.btn_options.OnPressedColor = System.Drawing.Color.Black;
            this.btn_options.Radius = 5;
            this.btn_options.Size = new System.Drawing.Size(194, 42);
            this.btn_options.TabIndex = 2;
            this.btn_options.Text = "Options";
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // uc_SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_options);
            this.Name = "uc_SettingsMenu";
            this.Size = new System.Drawing.Size(200, 734);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_profil;
        private Guna.UI.WinForms.GunaButton btn_options;
    }
}
