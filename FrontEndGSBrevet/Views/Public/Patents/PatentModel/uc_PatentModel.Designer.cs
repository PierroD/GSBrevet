﻿namespace FrontEndGSBrevet.Views.Public.Patents.PatentModel
{
    partial class uc_PatentModel
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
            this.btn_delete = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_edit = new Guna.UI.WinForms.GunaCircleButton();
            this.lbl_country = new Guna.UI.WinForms.GunaLabel();
            this.lbl_duration = new Guna.UI.WinForms.GunaLabel();
            this.lbl_deposit_date = new Guna.UI.WinForms.GunaLabel();
            this.lbl_company = new Guna.UI.WinForms.GunaLabel();
            this.lbl_molecule = new Guna.UI.WinForms.GunaLabel();
            this.lbl_number = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btn_delete);
            this.gunaShadowPanel1.Controls.Add(this.btn_edit);
            this.gunaShadowPanel1.Controls.Add(this.lbl_country);
            this.gunaShadowPanel1.Controls.Add(this.lbl_duration);
            this.gunaShadowPanel1.Controls.Add(this.lbl_deposit_date);
            this.gunaShadowPanel1.Controls.Add(this.lbl_company);
            this.gunaShadowPanel1.Controls.Add(this.lbl_molecule);
            this.gunaShadowPanel1.Controls.Add(this.lbl_number);
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
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_country
            // 
            this.lbl_country.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.Location = new System.Drawing.Point(750, 20);
            this.lbl_country.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(140, 20);
            this.lbl_country.TabIndex = 12;
            this.lbl_country.Text = "PAYS";
            this.lbl_country.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_duration
            // 
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.Location = new System.Drawing.Point(610, 20);
            this.lbl_duration.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(140, 20);
            this.lbl_duration.TabIndex = 11;
            this.lbl_duration.Text = "DUREE";
            this.lbl_duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_deposit_date
            // 
            this.lbl_deposit_date.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deposit_date.Location = new System.Drawing.Point(460, 20);
            this.lbl_deposit_date.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_deposit_date.Name = "lbl_deposit_date";
            this.lbl_deposit_date.Size = new System.Drawing.Size(140, 20);
            this.lbl_deposit_date.TabIndex = 10;
            this.lbl_deposit_date.Text = "DATE DE DEPOT";
            this.lbl_deposit_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_company
            // 
            this.lbl_company.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company.Location = new System.Drawing.Point(310, 20);
            this.lbl_company.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(140, 20);
            this.lbl_company.TabIndex = 9;
            this.lbl_company.Text = "ENTREPRISE";
            this.lbl_company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_molecule
            // 
            this.lbl_molecule.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_molecule.Location = new System.Drawing.Point(160, 20);
            this.lbl_molecule.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_molecule.Name = "lbl_molecule";
            this.lbl_molecule.Size = new System.Drawing.Size(140, 20);
            this.lbl_molecule.TabIndex = 8;
            this.lbl_molecule.Text = "MOLECULE";
            this.lbl_molecule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_number
            // 
            this.lbl_number.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(10, 20);
            this.lbl_number.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(140, 20);
            this.lbl_number.TabIndex = 7;
            this.lbl_number.Text = "NUMERO";
            // 
            // uc_PatentModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "uc_PatentModel";
            this.Size = new System.Drawing.Size(1010, 60);
            this.Load += new System.EventHandler(this.uc_PatentModel_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaCircleButton btn_delete;
        private Guna.UI.WinForms.GunaCircleButton btn_edit;
        private Guna.UI.WinForms.GunaLabel lbl_country;
        private Guna.UI.WinForms.GunaLabel lbl_duration;
        private Guna.UI.WinForms.GunaLabel lbl_deposit_date;
        private Guna.UI.WinForms.GunaLabel lbl_company;
        private Guna.UI.WinForms.GunaLabel lbl_molecule;
        private Guna.UI.WinForms.GunaLabel lbl_number;
    }
}
