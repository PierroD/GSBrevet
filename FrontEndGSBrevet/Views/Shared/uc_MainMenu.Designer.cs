﻿namespace FrontEndGSBrevet.Views.Shared
{
    partial class uc_MainMenu
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
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.btn_AllPatents = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::FrontEndGSBrevet.Properties.Resources.contracts;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(3, 63);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(194, 42);
            this.gunaButton2.TabIndex = 1;
            this.gunaButton2.Text = "Tous les contrats";
            // 
            // btn_AllPatents
            // 
            this.btn_AllPatents.AnimationHoverSpeed = 0.07F;
            this.btn_AllPatents.AnimationSpeed = 0.03F;
            this.btn_AllPatents.BackColor = System.Drawing.Color.Transparent;
            this.btn_AllPatents.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_AllPatents.BorderColor = System.Drawing.Color.Black;
            this.btn_AllPatents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AllPatents.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AllPatents.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AllPatents.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllPatents.ForeColor = System.Drawing.Color.White;
            this.btn_AllPatents.Image = global::FrontEndGSBrevet.Properties.Resources.patents;
            this.btn_AllPatents.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AllPatents.Location = new System.Drawing.Point(3, 3);
            this.btn_AllPatents.Name = "btn_AllPatents";
            this.btn_AllPatents.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_AllPatents.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_AllPatents.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AllPatents.OnHoverImage = null;
            this.btn_AllPatents.OnPressedColor = System.Drawing.Color.Black;
            this.btn_AllPatents.Radius = 5;
            this.btn_AllPatents.Size = new System.Drawing.Size(194, 42);
            this.btn_AllPatents.TabIndex = 0;
            this.btn_AllPatents.Text = "Tous les brevets";
            this.btn_AllPatents.Click += new System.EventHandler(this.btn_AllPatents_Click);
            // 
            // uc_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.btn_AllPatents);
            this.Name = "uc_MainMenu";
            this.Size = new System.Drawing.Size(200, 734);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_AllPatents;
        private Guna.UI.WinForms.GunaButton gunaButton2;
    }
}
