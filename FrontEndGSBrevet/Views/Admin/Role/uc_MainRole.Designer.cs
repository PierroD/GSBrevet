namespace FrontEndGSBrevet.Views.Admin.Role
{
    partial class uc_MainRole
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
            this.pnl_roles = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lbl_libelle = new Guna.UI.WinForms.GunaLabel();
            this.lbl_id = new Guna.UI.WinForms.GunaLabel();
            this.lbl_action = new Guna.UI.WinForms.GunaLabel();
            this.btn_send_to_database = new Guna.UI.WinForms.GunaTileButton();
            this.gunaPanel1.SuspendLayout();
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
            this.tbox_cu_libelle.Location = new System.Drawing.Point(709, 314);
            this.tbox_cu_libelle.Name = "tbox_cu_libelle";
            this.tbox_cu_libelle.PasswordChar = '\0';
            this.tbox_cu_libelle.Size = new System.Drawing.Size(397, 36);
            this.tbox_cu_libelle.TabIndex = 14;
            this.tbox_cu_libelle.Text = "Renseignez un nom de rôle";
            // 
            // lbl_cu_libelle
            // 
            this.lbl_cu_libelle.AutoSize = true;
            this.lbl_cu_libelle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cu_libelle.Location = new System.Drawing.Point(704, 286);
            this.lbl_cu_libelle.Name = "lbl_cu_libelle";
            this.lbl_cu_libelle.Size = new System.Drawing.Size(120, 25);
            this.lbl_cu_libelle.TabIndex = 13;
            this.lbl_cu_libelle.Text = "Nom du role";
            // 
            // pnl_roles
            // 
            this.pnl_roles.Location = new System.Drawing.Point(61, 70);
            this.pnl_roles.Name = "pnl_roles";
            this.pnl_roles.Size = new System.Drawing.Size(570, 655);
            this.pnl_roles.TabIndex = 18;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.lbl_action);
            this.gunaPanel1.Controls.Add(this.lbl_libelle);
            this.gunaPanel1.Controls.Add(this.lbl_id);
            this.gunaPanel1.Location = new System.Drawing.Point(61, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(515, 61);
            this.gunaPanel1.TabIndex = 19;
            // 
            // lbl_libelle
            // 
            this.lbl_libelle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_libelle.Location = new System.Drawing.Point(176, 22);
            this.lbl_libelle.MaximumSize = new System.Drawing.Size(160, 20);
            this.lbl_libelle.Name = "lbl_libelle";
            this.lbl_libelle.Size = new System.Drawing.Size(160, 20);
            this.lbl_libelle.TabIndex = 18;
            this.lbl_libelle.Text = "NOM";
            this.lbl_libelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(26, 22);
            this.lbl_id.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(140, 20);
            this.lbl_id.TabIndex = 17;
            this.lbl_id.Text = "ID";
            // 
            // lbl_action
            // 
            this.lbl_action.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_action.Location = new System.Drawing.Point(342, 22);
            this.lbl_action.MaximumSize = new System.Drawing.Size(160, 20);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(160, 20);
            this.lbl_action.TabIndex = 19;
            this.lbl_action.Text = "ACTION";
            this.lbl_action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_send_to_database.Location = new System.Drawing.Point(778, 376);
            this.btn_send_to_database.Name = "btn_send_to_database";
            this.btn_send_to_database.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_send_to_database.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_send_to_database.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_send_to_database.OnHoverImage = null;
            this.btn_send_to_database.OnPressedColor = System.Drawing.Color.Black;
            this.btn_send_to_database.Radius = 10;
            this.btn_send_to_database.Size = new System.Drawing.Size(229, 69);
            this.btn_send_to_database.TabIndex = 17;
            this.btn_send_to_database.Text = "Mettre à jour";
            // 
            // uc_MainRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.pnl_roles);
            this.Controls.Add(this.btn_send_to_database);
            this.Controls.Add(this.tbox_cu_libelle);
            this.Controls.Add(this.lbl_cu_libelle);
            this.Name = "uc_MainRole";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_MainRole_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLineTextBox tbox_cu_libelle;
        private Guna.UI.WinForms.GunaLabel lbl_cu_libelle;
        private Guna.UI.WinForms.GunaTileButton btn_send_to_database;
        private System.Windows.Forms.FlowLayoutPanel pnl_roles;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel lbl_libelle;
        private Guna.UI.WinForms.GunaLabel lbl_id;
        private Guna.UI.WinForms.GunaLabel lbl_action;
    }
}
