namespace FrontEndGSBrevet.Views.Public.Molecules.MoleculeModel
{
    partial class uc_MoleculeModel
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lbl_formula = new Guna.UI.WinForms.GunaLabel();
            this.lbl_real_name = new Guna.UI.WinForms.GunaLabel();
            this.lbl_generic_name = new Guna.UI.WinForms.GunaLabel();
            this.lbl_id = new Guna.UI.WinForms.GunaLabel();
            this.btn_delete = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_edit = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.lbl_formula);
            this.gunaShadowPanel1.Controls.Add(this.lbl_real_name);
            this.gunaShadowPanel1.Controls.Add(this.lbl_generic_name);
            this.gunaShadowPanel1.Controls.Add(this.lbl_id);
            this.gunaShadowPanel1.Controls.Add(this.btn_delete);
            this.gunaShadowPanel1.Controls.Add(this.btn_edit);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1010, 60);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // lbl_formula
            // 
            this.lbl_formula.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formula.Location = new System.Drawing.Point(667, 20);
            this.lbl_formula.MaximumSize = new System.Drawing.Size(220, 20);
            this.lbl_formula.Name = "lbl_formula";
            this.lbl_formula.Size = new System.Drawing.Size(220, 20);
            this.lbl_formula.TabIndex = 18;
            this.lbl_formula.Text = "FORMULE";
            this.lbl_formula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_real_name
            // 
            this.lbl_real_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_real_name.Location = new System.Drawing.Point(411, 20);
            this.lbl_real_name.MaximumSize = new System.Drawing.Size(250, 20);
            this.lbl_real_name.Name = "lbl_real_name";
            this.lbl_real_name.Size = new System.Drawing.Size(250, 20);
            this.lbl_real_name.TabIndex = 17;
            this.lbl_real_name.Text = "NOM CHIMIQUE";
            this.lbl_real_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_generic_name
            // 
            this.lbl_generic_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generic_name.Location = new System.Drawing.Point(155, 20);
            this.lbl_generic_name.MaximumSize = new System.Drawing.Size(250, 20);
            this.lbl_generic_name.Name = "lbl_generic_name";
            this.lbl_generic_name.Size = new System.Drawing.Size(250, 20);
            this.lbl_generic_name.TabIndex = 16;
            this.lbl_generic_name.Text = "NOM GENERIQUE";
            this.lbl_generic_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(5, 20);
            this.lbl_id.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(140, 20);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Text = "ID";
            // 
            // btn_delete
            // 
            this.btn_delete.AnimationHoverSpeed = 0.07F;
            this.btn_delete.AnimationSpeed = 0.03F;
            this.btn_delete.BaseColor = System.Drawing.Color.Red;
            this.btn_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::FrontEndGSBrevet.Properties.Resources.delete;
            this.btn_delete.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_delete.Location = new System.Drawing.Point(955, 8);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Size = new System.Drawing.Size(40, 40);
            this.btn_delete.TabIndex = 14;
            // 
            // btn_edit
            // 
            this.btn_edit.AnimationHoverSpeed = 0.07F;
            this.btn_edit.AnimationSpeed = 0.03F;
            this.btn_edit.BaseColor = System.Drawing.Color.White;
            this.btn_edit.BorderColor = System.Drawing.Color.Black;
            this.btn_edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = global::FrontEndGSBrevet.Properties.Resources.pen_off;
            this.btn_edit.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_edit.Location = new System.Drawing.Point(896, 8);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_edit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_edit.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_edit.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.pen_on;
            this.btn_edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_edit.Size = new System.Drawing.Size(40, 40);
            this.btn_edit.TabIndex = 13;
            // 
            // uc_MoleculeModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "uc_MoleculeModel";
            this.Size = new System.Drawing.Size(1010, 60);
            this.Load += new System.EventHandler(this.uc_MoleculeModel_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaCircleButton btn_delete;
        private Guna.UI.WinForms.GunaCircleButton btn_edit;
        private Guna.UI.WinForms.GunaLabel lbl_formula;
        private Guna.UI.WinForms.GunaLabel lbl_real_name;
        private Guna.UI.WinForms.GunaLabel lbl_generic_name;
        private Guna.UI.WinForms.GunaLabel lbl_id;
    }
}
