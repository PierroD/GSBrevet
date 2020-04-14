namespace InstallerGSBrevet.Location
{
    partial class uc_Location
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_folderbrowser = new System.Windows.Forms.Button();
            this.lbl_installationPath = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(228, 21);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Téléchargement de l\'application";
            // 
            // btn_folderbrowser
            // 
            this.btn_folderbrowser.BackColor = System.Drawing.SystemColors.Control;
            this.btn_folderbrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_folderbrowser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_folderbrowser.Location = new System.Drawing.Point(238, 50);
            this.btn_folderbrowser.Name = "btn_folderbrowser";
            this.btn_folderbrowser.Size = new System.Drawing.Size(201, 40);
            this.btn_folderbrowser.TabIndex = 2;
            this.btn_folderbrowser.Text = "Choisir le dossier d\'installation";
            this.btn_folderbrowser.UseVisualStyleBackColor = false;
            this.btn_folderbrowser.Click += new System.EventHandler(this.btn_folderbrowser_Click);
            // 
            // lbl_installationPath
            // 
            this.lbl_installationPath.AutoSize = true;
            this.lbl_installationPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_installationPath.Location = new System.Drawing.Point(457, 62);
            this.lbl_installationPath.Name = "lbl_installationPath";
            this.lbl_installationPath.Size = new System.Drawing.Size(140, 17);
            this.lbl_installationPath.TabIndex = 3;
            this.lbl_installationPath.Text = "Chemin d\'installation....";
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Location = new System.Drawing.Point(916, 117);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(81, 30);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Suivant >";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(829, 117);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(81, 30);
            this.btn_previous.TabIndex = 5;
            this.btn_previous.Text = "< Précédent";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // uc_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_installationPath);
            this.Controls.Add(this.btn_folderbrowser);
            this.Controls.Add(this.lbl_title);
            this.Name = "uc_Location";
            this.Size = new System.Drawing.Size(1000, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_folderbrowser;
        private System.Windows.Forms.Label lbl_installationPath;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
    }
}
