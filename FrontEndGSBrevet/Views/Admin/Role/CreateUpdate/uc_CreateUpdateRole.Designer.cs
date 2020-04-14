namespace FrontEndGSBrevet.Views.Admin.Role.CreateUpdate
{
    partial class uc_CreateUpdateRole
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
            this.tbox_cu_libelle = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_cu_libelle = new Guna.UI.WinForms.GunaLabel();
            this.btn_send_to_database = new Guna.UI.WinForms.GunaTileButton();
            this.SuspendLayout();
            // 
            // tbox_cu_libelle
            // 
            this.tbox_cu_libelle.BackColor = System.Drawing.Color.White;
            this.tbox_cu_libelle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_cu_libelle.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_cu_libelle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_cu_libelle.ForeColor = System.Drawing.Color.Gray;
            this.tbox_cu_libelle.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_cu_libelle.Location = new System.Drawing.Point(19, 45);
            this.tbox_cu_libelle.Name = "tbox_cu_libelle";
            this.tbox_cu_libelle.PasswordChar = '\0';
            this.tbox_cu_libelle.Size = new System.Drawing.Size(397, 36);
            this.tbox_cu_libelle.TabIndex = 19;
            this.tbox_cu_libelle.Text = "Renseignez un nom de rôle";
            this.tbox_cu_libelle.Enter += new System.EventHandler(this.tbox_cu_libelle_Enter);
            this.tbox_cu_libelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_cu_libelle_KeyPress);
            this.tbox_cu_libelle.Leave += new System.EventHandler(this.tbox_cu_libelle_Leave);
            // 
            // lbl_cu_libelle
            // 
            this.lbl_cu_libelle.AutoSize = true;
            this.lbl_cu_libelle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cu_libelle.Location = new System.Drawing.Point(14, 17);
            this.lbl_cu_libelle.Name = "lbl_cu_libelle";
            this.lbl_cu_libelle.Size = new System.Drawing.Size(120, 25);
            this.lbl_cu_libelle.TabIndex = 18;
            this.lbl_cu_libelle.Text = "Nom du role";
            // 
            // btn_send_to_database
            // 
            this.btn_send_to_database.AnimationHoverSpeed = 0.07F;
            this.btn_send_to_database.AnimationSpeed = 0.03F;
            this.btn_send_to_database.BackColor = System.Drawing.Color.Transparent;
            this.btn_send_to_database.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_send_to_database.BorderColor = System.Drawing.Color.Black;
            this.btn_send_to_database.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_send_to_database.FocusedColor = System.Drawing.Color.Empty;
            this.btn_send_to_database.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btn_send_to_database.ForeColor = System.Drawing.Color.White;
            this.btn_send_to_database.Image = global::FrontEndGSBrevet.Properties.Resources.save;
            this.btn_send_to_database.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_send_to_database.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_send_to_database.Location = new System.Drawing.Point(88, 107);
            this.btn_send_to_database.Name = "btn_send_to_database";
            this.btn_send_to_database.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_send_to_database.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_send_to_database.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_send_to_database.OnHoverImage = null;
            this.btn_send_to_database.OnPressedColor = System.Drawing.Color.Black;
            this.btn_send_to_database.Radius = 10;
            this.btn_send_to_database.Size = new System.Drawing.Size(229, 69);
            this.btn_send_to_database.TabIndex = 20;
            this.btn_send_to_database.Text = "Mettre à jour";
            this.btn_send_to_database.Click += new System.EventHandler(this.btn_send_to_database_Click);
            // 
            // uc_CreateUpdateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_send_to_database);
            this.Controls.Add(this.tbox_cu_libelle);
            this.Controls.Add(this.lbl_cu_libelle);
            this.Name = "uc_CreateUpdateRole";
            this.Size = new System.Drawing.Size(430, 200);
            this.Load += new System.EventHandler(this.uc_CreateUpdateRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTileButton btn_send_to_database;
        private Guna.UI.WinForms.GunaLineTextBox tbox_cu_libelle;
        private Guna.UI.WinForms.GunaLabel lbl_cu_libelle;
    }
}
