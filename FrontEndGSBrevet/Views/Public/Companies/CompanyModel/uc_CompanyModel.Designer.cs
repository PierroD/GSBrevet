namespace FrontEndGSBrevet.Views.Public.Companies.CompanyModel
{
    partial class uc_CompanyModel
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
            this.lbl_zip_code = new Guna.UI.WinForms.GunaLabel();
            this.lbl_city = new Guna.UI.WinForms.GunaLabel();
            this.lbl_address = new Guna.UI.WinForms.GunaLabel();
            this.lbl_name = new Guna.UI.WinForms.GunaLabel();
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
            this.gunaShadowPanel1.Controls.Add(this.lbl_zip_code);
            this.gunaShadowPanel1.Controls.Add(this.lbl_city);
            this.gunaShadowPanel1.Controls.Add(this.lbl_address);
            this.gunaShadowPanel1.Controls.Add(this.lbl_name);
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
            // lbl_zip_code
            // 
            this.lbl_zip_code.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zip_code.Location = new System.Drawing.Point(750, 20);
            this.lbl_zip_code.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_zip_code.Name = "lbl_zip_code";
            this.lbl_zip_code.Size = new System.Drawing.Size(140, 20);
            this.lbl_zip_code.TabIndex = 19;
            this.lbl_zip_code.Text = "CODE POSTAL";
            this.lbl_zip_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_city
            // 
            this.lbl_city.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.Location = new System.Drawing.Point(604, 20);
            this.lbl_city.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(140, 20);
            this.lbl_city.TabIndex = 18;
            this.lbl_city.Text = "VILLE";
            this.lbl_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_address
            // 
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(302, 20);
            this.lbl_address.MaximumSize = new System.Drawing.Size(296, 20);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(296, 20);
            this.lbl_address.TabIndex = 17;
            this.lbl_address.Text = "ADRESSE";
            this.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(156, 20);
            this.lbl_name.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(140, 20);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "NOM";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(6, 20);
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
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // uc_CompanyModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "uc_CompanyModel";
            this.Size = new System.Drawing.Size(1010, 60);
            this.Load += new System.EventHandler(this.uc_CompanyModel_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaCircleButton btn_delete;
        private Guna.UI.WinForms.GunaCircleButton btn_edit;
        private Guna.UI.WinForms.GunaLabel lbl_zip_code;
        private Guna.UI.WinForms.GunaLabel lbl_city;
        private Guna.UI.WinForms.GunaLabel lbl_address;
        private Guna.UI.WinForms.GunaLabel lbl_name;
        private Guna.UI.WinForms.GunaLabel lbl_id;
    }
}
