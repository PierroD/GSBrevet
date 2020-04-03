namespace FrontEndGSBrevet.Views.Public.Patents.CreateUpdate
{
    partial class uc_CreateUpdatePatent
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
            this.lbl_country = new Guna.UI.WinForms.GunaLabel();
            this.tbox_country = new Guna.UI.WinForms.GunaLineTextBox();
            this.tbox_number = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_number = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btn_send_to_database = new Guna.UI.WinForms.GunaTileButton();
            this.btn_back_to_AllPatents = new Guna.UI.WinForms.GunaButton();
            this.nbox_duration = new Guna.UI.WinForms.GunaNumeric();
            this.lbl_duration = new Guna.UI.WinForms.GunaLabel();
            this.lbl_create_date = new Guna.UI.WinForms.GunaLabel();
            this.dtime_deposit_date = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_molecule = new Guna.UI.WinForms.GunaLabel();
            this.lbl_companies = new Guna.UI.WinForms.GunaLabel();
            this.cbox_companies = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbox_molecules = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.Location = new System.Drawing.Point(307, 186);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(126, 25);
            this.lbl_country.TabIndex = 9;
            this.lbl_country.Text = "Nom du pays";
            // 
            // tbox_country
            // 
            this.tbox_country.BackColor = System.Drawing.Color.White;
            this.tbox_country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_country.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_country.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_country.ForeColor = System.Drawing.Color.Gray;
            this.tbox_country.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_country.Location = new System.Drawing.Point(312, 214);
            this.tbox_country.Name = "tbox_country";
            this.tbox_country.PasswordChar = '\0';
            this.tbox_country.Size = new System.Drawing.Size(473, 36);
            this.tbox_country.TabIndex = 10;
            this.tbox_country.Text = "Renseignez un nom de pays";
            this.tbox_country.Enter += new System.EventHandler(this.tbox_country_Enter);
            this.tbox_country.Leave += new System.EventHandler(this.tbox_country_Leave);
            // 
            // tbox_number
            // 
            this.tbox_number.BackColor = System.Drawing.Color.White;
            this.tbox_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_number.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_number.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_number.ForeColor = System.Drawing.Color.Gray;
            this.tbox_number.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_number.Location = new System.Drawing.Point(312, 325);
            this.tbox_number.Name = "tbox_number";
            this.tbox_number.PasswordChar = '\0';
            this.tbox_number.Size = new System.Drawing.Size(473, 36);
            this.tbox_number.TabIndex = 12;
            this.tbox_number.Text = "Renseignez numéro de brevet";
            this.tbox_number.Enter += new System.EventHandler(this.tbox_number_Enter);
            this.tbox_number.Leave += new System.EventHandler(this.tbox_number_Leave);
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(307, 297);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(263, 25);
            this.lbl_number.TabIndex = 11;
            this.lbl_number.Text = "Numéro du brevet (sans GSB)";
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
            // btn_back_to_AllPatents
            // 
            this.btn_back_to_AllPatents.AnimationHoverSpeed = 0.07F;
            this.btn_back_to_AllPatents.AnimationSpeed = 0.03F;
            this.btn_back_to_AllPatents.BackColor = System.Drawing.Color.Transparent;
            this.btn_back_to_AllPatents.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_back_to_AllPatents.BorderColor = System.Drawing.Color.Black;
            this.btn_back_to_AllPatents.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_back_to_AllPatents.FocusedColor = System.Drawing.Color.Empty;
            this.btn_back_to_AllPatents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_to_AllPatents.ForeColor = System.Drawing.Color.White;
            this.btn_back_to_AllPatents.Image = global::FrontEndGSBrevet.Properties.Resources.back;
            this.btn_back_to_AllPatents.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_back_to_AllPatents.Location = new System.Drawing.Point(3, 3);
            this.btn_back_to_AllPatents.Name = "btn_back_to_AllPatents";
            this.btn_back_to_AllPatents.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_back_to_AllPatents.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_back_to_AllPatents.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_back_to_AllPatents.OnHoverImage = null;
            this.btn_back_to_AllPatents.OnPressedColor = System.Drawing.Color.Black;
            this.btn_back_to_AllPatents.Radius = 6;
            this.btn_back_to_AllPatents.Size = new System.Drawing.Size(182, 42);
            this.btn_back_to_AllPatents.TabIndex = 8;
            this.btn_back_to_AllPatents.Text = "Toutes les brevets";
            this.btn_back_to_AllPatents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_back_to_AllPatents.Click += new System.EventHandler(this.btn_back_to_AllPatents_Click);
            // 
            // nbox_duration
            // 
            this.nbox_duration.BaseColor = System.Drawing.Color.White;
            this.nbox_duration.BorderColor = System.Drawing.Color.Silver;
            this.nbox_duration.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.nbox_duration.ButtonForeColor = System.Drawing.Color.White;
            this.nbox_duration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nbox_duration.ForeColor = System.Drawing.Color.Black;
            this.nbox_duration.Location = new System.Drawing.Point(656, 436);
            this.nbox_duration.Maximum = ((long)(9999999));
            this.nbox_duration.Minimum = ((long)(0));
            this.nbox_duration.Name = "nbox_duration";
            this.nbox_duration.Size = new System.Drawing.Size(78, 30);
            this.nbox_duration.TabIndex = 17;
            this.nbox_duration.Text = "gunaNumeric1";
            this.nbox_duration.Value = ((long)(0));
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.Location = new System.Drawing.Point(651, 408);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(74, 25);
            this.lbl_duration.TabIndex = 18;
            this.lbl_duration.Text = "Durée :";
            this.lbl_duration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_create_date
            // 
            this.lbl_create_date.AutoSize = true;
            this.lbl_create_date.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_create_date.Location = new System.Drawing.Point(346, 408);
            this.lbl_create_date.Name = "lbl_create_date";
            this.lbl_create_date.Size = new System.Drawing.Size(164, 25);
            this.lbl_create_date.TabIndex = 19;
            this.lbl_create_date.Text = "Date de création :";
            this.lbl_create_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtime_deposit_date
            // 
            this.dtime_deposit_date.BaseColor = System.Drawing.Color.White;
            this.dtime_deposit_date.BorderColor = System.Drawing.Color.Silver;
            this.dtime_deposit_date.CustomFormat = null;
            this.dtime_deposit_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtime_deposit_date.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtime_deposit_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtime_deposit_date.ForeColor = System.Drawing.Color.Black;
            this.dtime_deposit_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_deposit_date.Location = new System.Drawing.Point(333, 436);
            this.dtime_deposit_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtime_deposit_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtime_deposit_date.Name = "dtime_deposit_date";
            this.dtime_deposit_date.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtime_deposit_date.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtime_deposit_date.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtime_deposit_date.OnPressedColor = System.Drawing.Color.Black;
            this.dtime_deposit_date.Size = new System.Drawing.Size(223, 30);
            this.dtime_deposit_date.TabIndex = 20;
            this.dtime_deposit_date.Text = "02/04/2020";
            this.dtime_deposit_date.Value = new System.DateTime(2020, 4, 2, 0, 0, 0, 0);
            // 
            // lbl_molecule
            // 
            this.lbl_molecule.AutoSize = true;
            this.lbl_molecule.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_molecule.Location = new System.Drawing.Point(307, 74);
            this.lbl_molecule.Name = "lbl_molecule";
            this.lbl_molecule.Size = new System.Drawing.Size(194, 25);
            this.lbl_molecule.TabIndex = 21;
            this.lbl_molecule.Text = "Nom de la molécule :";
            // 
            // lbl_companies
            // 
            this.lbl_companies.AutoSize = true;
            this.lbl_companies.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_companies.Location = new System.Drawing.Point(570, 74);
            this.lbl_companies.Name = "lbl_companies";
            this.lbl_companies.Size = new System.Drawing.Size(286, 25);
            this.lbl_companies.TabIndex = 22;
            this.lbl_companies.Text = "Nom de l\'entreprise partenaire :";
            // 
            // cbox_companies
            // 
            this.cbox_companies.BackColor = System.Drawing.Color.Transparent;
            this.cbox_companies.BaseColor = System.Drawing.Color.White;
            this.cbox_companies.BorderColor = System.Drawing.Color.Silver;
            this.cbox_companies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_companies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_companies.FocusedColor = System.Drawing.Color.Empty;
            this.cbox_companies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbox_companies.ForeColor = System.Drawing.Color.Black;
            this.cbox_companies.FormattingEnabled = true;
            this.cbox_companies.Location = new System.Drawing.Point(575, 108);
            this.cbox_companies.Name = "cbox_companies";
            this.cbox_companies.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.cbox_companies.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbox_companies.Size = new System.Drawing.Size(190, 26);
            this.cbox_companies.TabIndex = 24;
            this.cbox_companies.Click += new System.EventHandler(this.cbox_companies_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gunaLabel1.Location = new System.Drawing.Point(740, 441);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(42, 19);
            this.gunaLabel1.TabIndex = 25;
            this.gunaLabel1.Text = "An(s)";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbox_molecules
            // 
            this.cbox_molecules.BackColor = System.Drawing.Color.Transparent;
            this.cbox_molecules.BaseColor = System.Drawing.Color.White;
            this.cbox_molecules.BorderColor = System.Drawing.Color.Silver;
            this.cbox_molecules.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_molecules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_molecules.FocusedColor = System.Drawing.Color.Empty;
            this.cbox_molecules.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbox_molecules.ForeColor = System.Drawing.Color.Black;
            this.cbox_molecules.FormattingEnabled = true;
            this.cbox_molecules.Location = new System.Drawing.Point(311, 108);
            this.cbox_molecules.Name = "cbox_molecules";
            this.cbox_molecules.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.cbox_molecules.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbox_molecules.Size = new System.Drawing.Size(190, 26);
            this.cbox_molecules.TabIndex = 26;
            this.cbox_molecules.Click += new System.EventHandler(this.cbox_molecules_Click);
            // 
            // uc_CreateUpdatePatent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbox_molecules);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.cbox_companies);
            this.Controls.Add(this.lbl_companies);
            this.Controls.Add(this.lbl_molecule);
            this.Controls.Add(this.dtime_deposit_date);
            this.Controls.Add(this.lbl_create_date);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.nbox_duration);
            this.Controls.Add(this.btn_send_to_database);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.tbox_number);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.tbox_country);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.btn_back_to_AllPatents);
            this.Name = "uc_CreateUpdatePatent";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_CreateUpdatePatent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_back_to_AllPatents;
        private Guna.UI.WinForms.GunaLabel lbl_country;
        private Guna.UI.WinForms.GunaLineTextBox tbox_country;
        private Guna.UI.WinForms.GunaLineTextBox tbox_number;
        private Guna.UI.WinForms.GunaLabel lbl_number;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaTileButton btn_send_to_database;
        private Guna.UI.WinForms.GunaNumeric nbox_duration;
        private Guna.UI.WinForms.GunaLabel lbl_duration;
        private Guna.UI.WinForms.GunaLabel lbl_create_date;
        private Guna.UI.WinForms.GunaDateTimePicker dtime_deposit_date;
        private Guna.UI.WinForms.GunaLabel lbl_molecule;
        private Guna.UI.WinForms.GunaLabel lbl_companies;
        private Guna.UI.WinForms.GunaComboBox cbox_companies;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbox_molecules;
    }
}
