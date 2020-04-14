namespace InstallerGSBrevet.Download
{
    partial class uc_Download
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
            this.pbar_download = new System.Windows.Forms.ProgressBar();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(228, 21);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Téléchargement de l\'application";
            // 
            // pbar_download
            // 
            this.pbar_download.Location = new System.Drawing.Point(41, 65);
            this.pbar_download.Name = "pbar_download";
            this.pbar_download.Size = new System.Drawing.Size(802, 30);
            this.pbar_download.TabIndex = 1;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lbl_progress.Location = new System.Drawing.Point(872, 65);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(0, 30);
            this.lbl_progress.TabIndex = 2;
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Location = new System.Drawing.Point(916, 117);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(81, 30);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Suivant >";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // uc_Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.pbar_download);
            this.Controls.Add(this.lbl_title);
            this.Name = "uc_Download";
            this.Size = new System.Drawing.Size(1000, 150);
            this.Load += new System.EventHandler(this.uc_Download_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ProgressBar pbar_download;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.Button btn_next;
    }
}
