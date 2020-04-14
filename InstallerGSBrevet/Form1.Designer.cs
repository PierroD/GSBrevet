namespace InstallerGSBrevet
{
    partial class form_Installer
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pbox_share = new System.Windows.Forms.PictureBox();
            this.tbox_log = new System.Windows.Forms.TextBox();
            this.timer_pbox = new System.Windows.Forms.Timer(this.components);
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_share)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.btn_Close);
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1000, 50);
            this.pnl_top.TabIndex = 0;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseMove);
            this.pnl_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Location = new System.Drawing.Point(922, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 35);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(196, 30);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "GSBrevets Installer";
            // 
            // pnl_main
            // 
            this.pnl_main.Location = new System.Drawing.Point(0, 317);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1000, 150);
            this.pnl_main.TabIndex = 1;
            // 
            // pbox_share
            // 
            this.pbox_share.BackColor = System.Drawing.Color.Red;
            this.pbox_share.Location = new System.Drawing.Point(176, 56);
            this.pbox_share.Name = "pbox_share";
            this.pbox_share.Size = new System.Drawing.Size(643, 255);
            this.pbox_share.TabIndex = 2;
            this.pbox_share.TabStop = false;
            // 
            // tbox_log
            // 
            this.tbox_log.Location = new System.Drawing.Point(176, 473);
            this.tbox_log.Multiline = true;
            this.tbox_log.Name = "tbox_log";
            this.tbox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_log.Size = new System.Drawing.Size(643, 125);
            this.tbox_log.TabIndex = 3;
            // 
            // timer_pbox
            // 
            this.timer_pbox.Interval = 4000;
            // 
            // form_Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tbox_log);
            this.Controls.Add(this.pbox_share);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Installer";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.form_Installer_Shown);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_share)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.PictureBox pbox_share;
        private System.Windows.Forms.TextBox tbox_log;
        private System.Windows.Forms.Timer timer_pbox;
    }
}

