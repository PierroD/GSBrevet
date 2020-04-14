namespace FrontEndGSBrevet.Views.Public.Companies.CreateUpdate
{
    partial class uc_CreateUpdateCompany
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
            this.lbl_name = new Guna.UI.WinForms.GunaLabel();
            this.tbox_name = new Guna.UI.WinForms.GunaLineTextBox();
            this.tbox_address = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_address = new Guna.UI.WinForms.GunaLabel();
            this.tbox_city = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_city = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btn_send_to_database = new Guna.UI.WinForms.GunaTileButton();
            this.btn_back_to_AllCompanies = new Guna.UI.WinForms.GunaButton();
            this.tbox_zip_code = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_zip_code = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(306, 175);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(182, 25);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Nom de l\'entreprise";
            // 
            // tbox_name
            // 
            this.tbox_name.BackColor = System.Drawing.Color.White;
            this.tbox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_name.ForeColor = System.Drawing.Color.Gray;
            this.tbox_name.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_name.Location = new System.Drawing.Point(311, 203);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.PasswordChar = '\0';
            this.tbox_name.Size = new System.Drawing.Size(473, 36);
            this.tbox_name.TabIndex = 10;
            this.tbox_name.Text = "Renseignez un nom d\'entreprise";
            this.tbox_name.Enter += new System.EventHandler(this.tbox_name_Enter);
            this.tbox_name.Leave += new System.EventHandler(this.tbox_name_Leave);
            // 
            // tbox_address
            // 
            this.tbox_address.BackColor = System.Drawing.Color.White;
            this.tbox_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_address.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_address.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_address.ForeColor = System.Drawing.Color.Gray;
            this.tbox_address.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_address.Location = new System.Drawing.Point(311, 314);
            this.tbox_address.Name = "tbox_address";
            this.tbox_address.PasswordChar = '\0';
            this.tbox_address.Size = new System.Drawing.Size(473, 36);
            this.tbox_address.TabIndex = 12;
            this.tbox_address.Text = "Renseignez une adresse";
            this.tbox_address.Enter += new System.EventHandler(this.tbox_address_Enter);
            this.tbox_address.Leave += new System.EventHandler(this.tbox_address_Leave);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(306, 286);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(206, 25);
            this.lbl_address.TabIndex = 11;
            this.lbl_address.Text = "Adresse de l\'entreprise";
            // 
            // tbox_city
            // 
            this.tbox_city.BackColor = System.Drawing.Color.White;
            this.tbox_city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_city.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_city.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_city.ForeColor = System.Drawing.Color.Gray;
            this.tbox_city.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_city.Location = new System.Drawing.Point(223, 418);
            this.tbox_city.Name = "tbox_city";
            this.tbox_city.PasswordChar = '\0';
            this.tbox_city.Size = new System.Drawing.Size(349, 36);
            this.tbox_city.TabIndex = 14;
            this.tbox_city.Text = "Renseignez une ville";
            this.tbox_city.Enter += new System.EventHandler(this.tbox_city_Enter);
            this.tbox_city.Leave += new System.EventHandler(this.tbox_city_Leave);
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.Location = new System.Drawing.Point(218, 390);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(49, 25);
            this.lbl_city.TabIndex = 13;
            this.lbl_city.Text = "Ville";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(165, 504);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(778, 10);
            this.gunaSeparator1.TabIndex = 15;
            // 
            // btn_send_to_database
            // 
            this.btn_send_to_database.AnimationHoverSpeed = 0.07F;
            this.btn_send_to_database.AnimationSpeed = 0.03F;
            this.btn_send_to_database.BackColor = System.Drawing.Color.Transparent;
            this.btn_send_to_database.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_send_to_database.BorderColor = System.Drawing.Color.Black;
            this.btn_send_to_database.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_send_to_database.FocusedColor = System.Drawing.Color.Empty;
            this.btn_send_to_database.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btn_send_to_database.ForeColor = System.Drawing.Color.White;
            this.btn_send_to_database.Image = global::FrontEndGSBrevet.Properties.Resources.save;
            this.btn_send_to_database.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_send_to_database.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_send_to_database.Location = new System.Drawing.Point(419, 539);
            this.btn_send_to_database.Name = "btn_send_to_database";
            this.btn_send_to_database.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_send_to_database.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_send_to_database.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_send_to_database.OnHoverImage = null;
            this.btn_send_to_database.OnPressedColor = System.Drawing.Color.Black;
            this.btn_send_to_database.Radius = 10;
            this.btn_send_to_database.Size = new System.Drawing.Size(229, 69);
            this.btn_send_to_database.TabIndex = 16;
            this.btn_send_to_database.Text = "Mettre à jour";
            this.btn_send_to_database.Click += new System.EventHandler(this.btn_send_to_database_Click);
            // 
            // btn_back_to_AllCompanies
            // 
            this.btn_back_to_AllCompanies.AnimationHoverSpeed = 0.07F;
            this.btn_back_to_AllCompanies.AnimationSpeed = 0.03F;
            this.btn_back_to_AllCompanies.BackColor = System.Drawing.Color.Transparent;
            this.btn_back_to_AllCompanies.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_back_to_AllCompanies.BorderColor = System.Drawing.Color.Black;
            this.btn_back_to_AllCompanies.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_back_to_AllCompanies.FocusedColor = System.Drawing.Color.Empty;
            this.btn_back_to_AllCompanies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_to_AllCompanies.ForeColor = System.Drawing.Color.White;
            this.btn_back_to_AllCompanies.Image = global::FrontEndGSBrevet.Properties.Resources.back;
            this.btn_back_to_AllCompanies.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_back_to_AllCompanies.Location = new System.Drawing.Point(3, 3);
            this.btn_back_to_AllCompanies.Name = "btn_back_to_AllCompanies";
            this.btn_back_to_AllCompanies.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_back_to_AllCompanies.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_back_to_AllCompanies.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_back_to_AllCompanies.OnHoverImage = null;
            this.btn_back_to_AllCompanies.OnPressedColor = System.Drawing.Color.Black;
            this.btn_back_to_AllCompanies.Radius = 6;
            this.btn_back_to_AllCompanies.Size = new System.Drawing.Size(182, 42);
            this.btn_back_to_AllCompanies.TabIndex = 8;
            this.btn_back_to_AllCompanies.Text = "Toutes les entreprises";
            this.btn_back_to_AllCompanies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_back_to_AllCompanies.Click += new System.EventHandler(this.btn_back_to_AllCompanies_Click);
            // 
            // tbox_zip_code
            // 
            this.tbox_zip_code.BackColor = System.Drawing.Color.White;
            this.tbox_zip_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_zip_code.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_zip_code.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_zip_code.ForeColor = System.Drawing.Color.Gray;
            this.tbox_zip_code.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_zip_code.Location = new System.Drawing.Point(601, 418);
            this.tbox_zip_code.Name = "tbox_zip_code";
            this.tbox_zip_code.PasswordChar = '\0';
            this.tbox_zip_code.Size = new System.Drawing.Size(284, 36);
            this.tbox_zip_code.TabIndex = 18;
            this.tbox_zip_code.Text = "Renseignez un code postal";
            this.tbox_zip_code.Enter += new System.EventHandler(this.tbox_zip_code_Enter);
            this.tbox_zip_code.Leave += new System.EventHandler(this.tbox_zip_code_Leave);
            // 
            // lbl_zip_code
            // 
            this.lbl_zip_code.AutoSize = true;
            this.lbl_zip_code.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zip_code.Location = new System.Drawing.Point(596, 390);
            this.lbl_zip_code.Name = "lbl_zip_code";
            this.lbl_zip_code.Size = new System.Drawing.Size(113, 25);
            this.lbl_zip_code.TabIndex = 17;
            this.lbl_zip_code.Text = "Code postal";
            // 
            // uc_CreateUpdateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbox_zip_code);
            this.Controls.Add(this.lbl_zip_code);
            this.Controls.Add(this.btn_send_to_database);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.tbox_city);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.tbox_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_back_to_AllCompanies);
            this.Name = "uc_CreateUpdateCompany";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_CreateUpdateCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_back_to_AllCompanies;
        private Guna.UI.WinForms.GunaLabel lbl_name;
        private Guna.UI.WinForms.GunaLineTextBox tbox_name;
        private Guna.UI.WinForms.GunaLineTextBox tbox_address;
        private Guna.UI.WinForms.GunaLabel lbl_address;
        private Guna.UI.WinForms.GunaLineTextBox tbox_city;
        private Guna.UI.WinForms.GunaLabel lbl_city;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaTileButton btn_send_to_database;
        private Guna.UI.WinForms.GunaLineTextBox tbox_zip_code;
        private Guna.UI.WinForms.GunaLabel lbl_zip_code;
    }
}
