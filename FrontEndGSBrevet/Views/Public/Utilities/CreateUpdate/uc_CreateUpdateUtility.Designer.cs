namespace FrontEndGSBrevet.Views.Public.Utilities.CreateUpdate
{
    partial class uc_CreateUpdateUtility
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
            this.lbl_description = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btn_send_to_database = new Guna.UI.WinForms.GunaTileButton();
            this.btn_back_to_AllPatents = new Guna.UI.WinForms.GunaButton();
            this.lbl_molecule = new Guna.UI.WinForms.GunaLabel();
            this.cbox_molecules = new Guna.UI.WinForms.GunaComboBox();
            this.tbox_description = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(307, 186);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(156, 25);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Nom de l\'utilitée";
            // 
            // tbox_name
            // 
            this.tbox_name.BackColor = System.Drawing.Color.White;
            this.tbox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_name.ForeColor = System.Drawing.Color.Gray;
            this.tbox_name.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_name.Location = new System.Drawing.Point(312, 214);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.PasswordChar = '\0';
            this.tbox_name.Size = new System.Drawing.Size(473, 36);
            this.tbox_name.TabIndex = 10;
            this.tbox_name.Text = "Renseignez un nom d\'utilitée";
            this.tbox_name.Enter += new System.EventHandler(this.tbox_utility_Enter);
            this.tbox_name.Leave += new System.EventHandler(this.tbox_utility_Leave);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(307, 297);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(211, 25);
            this.lbl_description.TabIndex = 11;
            this.lbl_description.Text = "Description de l\'utilitée";
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
            this.btn_back_to_AllPatents.Text = "Toutes les utilitées";
            this.btn_back_to_AllPatents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_back_to_AllPatents.Click += new System.EventHandler(this.btn_back_to_AllPatents_Click);
            // 
            // lbl_molecule
            // 
            this.lbl_molecule.AutoSize = true;
            this.lbl_molecule.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_molecule.Location = new System.Drawing.Point(307, 105);
            this.lbl_molecule.Name = "lbl_molecule";
            this.lbl_molecule.Size = new System.Drawing.Size(194, 25);
            this.lbl_molecule.TabIndex = 21;
            this.lbl_molecule.Text = "Nom de la molécule :";
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
            this.cbox_molecules.Location = new System.Drawing.Point(311, 139);
            this.cbox_molecules.Name = "cbox_molecules";
            this.cbox_molecules.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.cbox_molecules.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbox_molecules.Size = new System.Drawing.Size(190, 26);
            this.cbox_molecules.TabIndex = 26;
            this.cbox_molecules.Click += new System.EventHandler(this.cbox_molecules_Click);
            // 
            // tbox_description
            // 
            this.tbox_description.BaseColor = System.Drawing.Color.White;
            this.tbox_description.BorderColor = System.Drawing.Color.Silver;
            this.tbox_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_description.FocusedBaseColor = System.Drawing.Color.White;
            this.tbox_description.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_description.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbox_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_description.ForeColor = System.Drawing.Color.Gray;
            this.tbox_description.Location = new System.Drawing.Point(311, 325);
            this.tbox_description.MultiLine = true;
            this.tbox_description.Name = "tbox_description";
            this.tbox_description.PasswordChar = '\0';
            this.tbox_description.Size = new System.Drawing.Size(474, 159);
            this.tbox_description.TabIndex = 27;
            this.tbox_description.Text = "Renseigner une description";
            this.tbox_description.Enter += new System.EventHandler(this.tbox_description_Enter);
            this.tbox_description.Leave += new System.EventHandler(this.tbox_description_Leave);
            // 
            // uc_CreateUpdateUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbox_description);
            this.Controls.Add(this.cbox_molecules);
            this.Controls.Add(this.lbl_molecule);
            this.Controls.Add(this.btn_send_to_database);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_back_to_AllPatents);
            this.Name = "uc_CreateUpdateUtility";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_CreateUpdateUtility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_back_to_AllPatents;
        private Guna.UI.WinForms.GunaLabel lbl_name;
        private Guna.UI.WinForms.GunaLineTextBox tbox_name;
        private Guna.UI.WinForms.GunaLabel lbl_description;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaTileButton btn_send_to_database;
        private Guna.UI.WinForms.GunaLabel lbl_molecule;
        private Guna.UI.WinForms.GunaComboBox cbox_molecules;
        private Guna.UI.WinForms.GunaTextBox tbox_description;
    }
}
