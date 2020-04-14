namespace FrontEndGSBrevet.Views.Public.Profil
{
    partial class uc_MainProfil
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
            this.lbl_uc_Title = new Guna.UI.WinForms.GunaLabel();
            this.Pbox_uc_image = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btn_initial = new Guna.UI.WinForms.GunaCircleButton();
            this.lbl_lastname = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_firstname = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator3 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_username = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator4 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_birthDate = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator5 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_role = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_uc_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_uc_Title
            // 
            this.lbl_uc_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uc_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_uc_Title.Location = new System.Drawing.Point(39, 3);
            this.lbl_uc_Title.Name = "lbl_uc_Title";
            this.lbl_uc_Title.Size = new System.Drawing.Size(50, 30);
            this.lbl_uc_Title.TabIndex = 3;
            this.lbl_uc_Title.Text = "Profil";
            this.lbl_uc_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pbox_uc_image
            // 
            this.Pbox_uc_image.BaseColor = System.Drawing.Color.Transparent;
            this.Pbox_uc_image.Image = global::FrontEndGSBrevet.Properties.Resources.user;
            this.Pbox_uc_image.Location = new System.Drawing.Point(3, 3);
            this.Pbox_uc_image.Name = "Pbox_uc_image";
            this.Pbox_uc_image.Size = new System.Drawing.Size(30, 30);
            this.Pbox_uc_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbox_uc_image.TabIndex = 2;
            this.Pbox_uc_image.TabStop = false;
            this.Pbox_uc_image.UseTransfarantBackground = false;
            // 
            // btn_initial
            // 
            this.btn_initial.AnimationHoverSpeed = 0.07F;
            this.btn_initial.AnimationSpeed = 0.03F;
            this.btn_initial.BaseColor = System.Drawing.Color.White;
            this.btn_initial.BorderColor = System.Drawing.Color.Black;
            this.btn_initial.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_initial.FocusedColor = System.Drawing.Color.Empty;
            this.btn_initial.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_initial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_initial.Image = null;
            this.btn_initial.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_initial.Location = new System.Drawing.Point(455, 72);
            this.btn_initial.Name = "btn_initial";
            this.btn_initial.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_initial.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_initial.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_initial.OnHoverImage = null;
            this.btn_initial.OnPressedColor = System.Drawing.Color.Black;
            this.btn_initial.Size = new System.Drawing.Size(200, 200);
            this.btn_initial.TabIndex = 4;
            this.btn_initial.Text = "PD";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.ForeColor = System.Drawing.Color.White;
            this.lbl_lastname.Location = new System.Drawing.Point(337, 336);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(51, 20);
            this.lbl_lastname.TabIndex = 5;
            this.lbl_lastname.Text = "Nom :";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.White;
            this.gunaSeparator1.Location = new System.Drawing.Point(341, 359);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(417, 10);
            this.gunaSeparator1.TabIndex = 6;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.White;
            this.gunaSeparator2.Location = new System.Drawing.Point(341, 408);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(417, 10);
            this.gunaSeparator2.TabIndex = 8;
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.ForeColor = System.Drawing.Color.White;
            this.lbl_firstname.Location = new System.Drawing.Point(337, 385);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(71, 20);
            this.lbl_firstname.TabIndex = 7;
            this.lbl_firstname.Text = "Prénom :";
            // 
            // gunaSeparator3
            // 
            this.gunaSeparator3.LineColor = System.Drawing.Color.White;
            this.gunaSeparator3.Location = new System.Drawing.Point(341, 456);
            this.gunaSeparator3.Name = "gunaSeparator3";
            this.gunaSeparator3.Size = new System.Drawing.Size(417, 10);
            this.gunaSeparator3.TabIndex = 10;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(337, 433);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(87, 20);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "Identifiant :";
            // 
            // gunaSeparator4
            // 
            this.gunaSeparator4.LineColor = System.Drawing.Color.White;
            this.gunaSeparator4.Location = new System.Drawing.Point(341, 501);
            this.gunaSeparator4.Name = "gunaSeparator4";
            this.gunaSeparator4.Size = new System.Drawing.Size(417, 10);
            this.gunaSeparator4.TabIndex = 12;
            // 
            // lbl_birthDate
            // 
            this.lbl_birthDate.AutoSize = true;
            this.lbl_birthDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthDate.ForeColor = System.Drawing.Color.White;
            this.lbl_birthDate.Location = new System.Drawing.Point(337, 478);
            this.lbl_birthDate.Name = "lbl_birthDate";
            this.lbl_birthDate.Size = new System.Drawing.Size(139, 20);
            this.lbl_birthDate.TabIndex = 11;
            this.lbl_birthDate.Text = "Date de naissance :";
            // 
            // gunaSeparator5
            // 
            this.gunaSeparator5.LineColor = System.Drawing.Color.White;
            this.gunaSeparator5.Location = new System.Drawing.Point(341, 548);
            this.gunaSeparator5.Name = "gunaSeparator5";
            this.gunaSeparator5.Size = new System.Drawing.Size(417, 10);
            this.gunaSeparator5.TabIndex = 14;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.White;
            this.lbl_role.Location = new System.Drawing.Point(337, 525);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(47, 20);
            this.lbl_role.TabIndex = 13;
            this.lbl_role.Text = "Role :";
            // 
            // uc_MainProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.gunaSeparator5);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.gunaSeparator4);
            this.Controls.Add(this.lbl_birthDate);
            this.Controls.Add(this.gunaSeparator3);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.btn_initial);
            this.Controls.Add(this.lbl_uc_Title);
            this.Controls.Add(this.Pbox_uc_image);
            this.Name = "uc_MainProfil";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_MainProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_uc_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbl_uc_Title;
        private Guna.UI.WinForms.GunaCirclePictureBox Pbox_uc_image;
        private Guna.UI.WinForms.GunaCircleButton btn_initial;
        private Guna.UI.WinForms.GunaLabel lbl_lastname;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaLabel lbl_firstname;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator3;
        private Guna.UI.WinForms.GunaLabel lbl_username;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator4;
        private Guna.UI.WinForms.GunaLabel lbl_birthDate;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator5;
        private Guna.UI.WinForms.GunaLabel lbl_role;
    }
}
