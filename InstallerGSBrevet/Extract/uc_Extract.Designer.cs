namespace InstallerGSBrevet.Extract
{
    partial class uc_Extract
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
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pbar_download = new System.Windows.Forms.ProgressBar();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(825, 113);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(81, 30);
            this.btn_previous.TabIndex = 8;
            this.btn_previous.Text = "< Précédent";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Location = new System.Drawing.Point(912, 113);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(81, 30);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = "Suivant >";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(8, 8);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(187, 21);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Extraction de l\'application";
            // 
            // pbar_download
            // 
            this.pbar_download.Location = new System.Drawing.Point(56, 60);
            this.pbar_download.Name = "pbar_download";
            this.pbar_download.Size = new System.Drawing.Size(802, 30);
            this.pbar_download.TabIndex = 9;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lbl_progress.Location = new System.Drawing.Point(906, 60);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(0, 30);
            this.lbl_progress.TabIndex = 10;
            // 
            // uc_Extract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.pbar_download);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_title);
            this.Name = "uc_Extract";
            this.Size = new System.Drawing.Size(1000, 150);
            this.Load += new System.EventHandler(this.uc_Extract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ProgressBar pbar_download;
        private System.Windows.Forms.Label lbl_progress;
    }
}
