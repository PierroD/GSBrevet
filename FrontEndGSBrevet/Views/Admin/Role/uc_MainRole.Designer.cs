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
            this.pnl_roles = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lbl_action = new Guna.UI.WinForms.GunaLabel();
            this.lbl_libelle = new Guna.UI.WinForms.GunaLabel();
            this.lbl_id = new Guna.UI.WinForms.GunaLabel();
            pnl_createUpdate = new Guna.UI.WinForms.GunaPanel();
            this.btn_create_role = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_roles
            // 
            this.pnl_roles.Location = new System.Drawing.Point(61, 70);
            this.pnl_roles.Name = "pnl_roles";
            this.pnl_roles.Size = new System.Drawing.Size(525, 655);
            this.pnl_roles.TabIndex = 18;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.lbl_action);
            this.gunaPanel1.Controls.Add(this.lbl_libelle);
            this.gunaPanel1.Controls.Add(this.lbl_id);
            this.gunaPanel1.Location = new System.Drawing.Point(61, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(495, 61);
            this.gunaPanel1.TabIndex = 19;
            // 
            // lbl_action
            // 
            this.lbl_action.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_action.Location = new System.Drawing.Point(325, 22);
            this.lbl_action.MaximumSize = new System.Drawing.Size(160, 20);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(160, 20);
            this.lbl_action.TabIndex = 19;
            this.lbl_action.Text = "ACTION";
            this.lbl_action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_libelle
            // 
            this.lbl_libelle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_libelle.Location = new System.Drawing.Point(159, 22);
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
            this.lbl_id.Location = new System.Drawing.Point(9, 22);
            this.lbl_id.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(140, 20);
            this.lbl_id.TabIndex = 17;
            this.lbl_id.Text = "ID";
            // 
            // pnl_createUpdate
            // 
            pnl_createUpdate.Location = new System.Drawing.Point(638, 73);
            pnl_createUpdate.Name = "pnl_createUpdate";
            pnl_createUpdate.Size = new System.Drawing.Size(430, 200);
            pnl_createUpdate.TabIndex = 20;
            // 
            // btn_create_role
            // 
            this.btn_create_role.AnimationHoverSpeed = 0.07F;
            this.btn_create_role.AnimationSpeed = 0.03F;
            this.btn_create_role.BackColor = System.Drawing.Color.Transparent;
            this.btn_create_role.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_create_role.BorderColor = System.Drawing.Color.Black;
            this.btn_create_role.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_role.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_create_role.FocusedColor = System.Drawing.Color.Empty;
            this.btn_create_role.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_role.ForeColor = System.Drawing.Color.White;
            this.btn_create_role.Image = global::FrontEndGSBrevet.Properties.Resources.plus;
            this.btn_create_role.ImageSize = new System.Drawing.Size(12, 12);
            this.btn_create_role.Location = new System.Drawing.Point(638, 22);
            this.btn_create_role.Name = "btn_create_role";
            this.btn_create_role.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_create_role.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_create_role.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_create_role.OnHoverImage = null;
            this.btn_create_role.OnPressedColor = System.Drawing.Color.Black;
            this.btn_create_role.Radius = 6;
            this.btn_create_role.Size = new System.Drawing.Size(145, 42);
            this.btn_create_role.TabIndex = 21;
            this.btn_create_role.Text = "CREER UN ROLE";
            this.btn_create_role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_create_role.Click += new System.EventHandler(this.btn_create_role_Click);
            // 
            // uc_MainRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_create_role);
            this.Controls.Add(pnl_createUpdate);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.pnl_roles);
            this.Name = "uc_MainRole";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_MainRole_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnl_roles;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel lbl_libelle;
        private Guna.UI.WinForms.GunaLabel lbl_id;
        private Guna.UI.WinForms.GunaLabel lbl_action;
        private Guna.UI.WinForms.GunaButton btn_create_role;
        public static Guna.UI.WinForms.GunaPanel pnl_createUpdate;
    }
}
