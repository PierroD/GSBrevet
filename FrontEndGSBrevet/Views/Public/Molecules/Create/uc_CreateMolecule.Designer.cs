namespace FrontEndGSBrevet.Views.Public.Molecules.Create
{
    partial class uc_CreateMolecule
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
            this.btn_back_to_AllMolecules = new Guna.UI.WinForms.GunaButton();
            this.lbl_generic_name = new Guna.UI.WinForms.GunaLabel();
            this.tbox_generic_name = new Guna.UI.WinForms.GunaLineTextBox();
            this.tbox_real_name = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_real_name = new Guna.UI.WinForms.GunaLabel();
            this.tbox_formula = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_formula = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btn_send_to_database = new Guna.UI.WinForms.GunaTileButton();
            this.SuspendLayout();
            // 
            // btn_back_to_AllMolecules
            // 
            this.btn_back_to_AllMolecules.AnimationHoverSpeed = 0.07F;
            this.btn_back_to_AllMolecules.AnimationSpeed = 0.03F;
            this.btn_back_to_AllMolecules.BackColor = System.Drawing.Color.Transparent;
            this.btn_back_to_AllMolecules.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_back_to_AllMolecules.BorderColor = System.Drawing.Color.Black;
            this.btn_back_to_AllMolecules.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_back_to_AllMolecules.FocusedColor = System.Drawing.Color.Empty;
            this.btn_back_to_AllMolecules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_to_AllMolecules.ForeColor = System.Drawing.Color.White;
            this.btn_back_to_AllMolecules.Image = global::FrontEndGSBrevet.Properties.Resources.back;
            this.btn_back_to_AllMolecules.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_back_to_AllMolecules.Location = new System.Drawing.Point(3, 3);
            this.btn_back_to_AllMolecules.Name = "btn_back_to_AllMolecules";
            this.btn_back_to_AllMolecules.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_back_to_AllMolecules.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_back_to_AllMolecules.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_back_to_AllMolecules.OnHoverImage = null;
            this.btn_back_to_AllMolecules.OnPressedColor = System.Drawing.Color.Black;
            this.btn_back_to_AllMolecules.Radius = 6;
            this.btn_back_to_AllMolecules.Size = new System.Drawing.Size(182, 42);
            this.btn_back_to_AllMolecules.TabIndex = 8;
            this.btn_back_to_AllMolecules.Text = "Toutes les molécules";
            this.btn_back_to_AllMolecules.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_back_to_AllMolecules.Click += new System.EventHandler(this.btn_back_to_AllMolecules_Click);
            // 
            // lbl_generic_name
            // 
            this.lbl_generic_name.AutoSize = true;
            this.lbl_generic_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generic_name.Location = new System.Drawing.Point(306, 175);
            this.lbl_generic_name.Name = "lbl_generic_name";
            this.lbl_generic_name.Size = new System.Drawing.Size(160, 25);
            this.lbl_generic_name.TabIndex = 9;
            this.lbl_generic_name.Text = "Nom commercial";
            // 
            // tbox_generic_name
            // 
            this.tbox_generic_name.BackColor = System.Drawing.Color.White;
            this.tbox_generic_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_generic_name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_generic_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_generic_name.ForeColor = System.Drawing.Color.Gray;
            this.tbox_generic_name.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_generic_name.Location = new System.Drawing.Point(311, 203);
            this.tbox_generic_name.Name = "tbox_generic_name";
            this.tbox_generic_name.PasswordChar = '\0';
            this.tbox_generic_name.Size = new System.Drawing.Size(473, 36);
            this.tbox_generic_name.TabIndex = 10;
            this.tbox_generic_name.Text = "Renseignez un nom commercial";
            this.tbox_generic_name.Enter += new System.EventHandler(this.tbox_generic_name_Enter);
            this.tbox_generic_name.Leave += new System.EventHandler(this.tbox_generic_name_Leave);
            // 
            // tbox_real_name
            // 
            this.tbox_real_name.BackColor = System.Drawing.Color.White;
            this.tbox_real_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_real_name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_real_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_real_name.ForeColor = System.Drawing.Color.Gray;
            this.tbox_real_name.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_real_name.Location = new System.Drawing.Point(311, 314);
            this.tbox_real_name.Name = "tbox_real_name";
            this.tbox_real_name.PasswordChar = '\0';
            this.tbox_real_name.Size = new System.Drawing.Size(473, 36);
            this.tbox_real_name.TabIndex = 12;
            this.tbox_real_name.Text = "Renseignez un vrai nom";
            this.tbox_real_name.Enter += new System.EventHandler(this.tbox_real_name_Enter);
            this.tbox_real_name.Leave += new System.EventHandler(this.tbox_real_name_Leave);
            // 
            // lbl_real_name
            // 
            this.lbl_real_name.AutoSize = true;
            this.lbl_real_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_real_name.Location = new System.Drawing.Point(306, 286);
            this.lbl_real_name.Name = "lbl_real_name";
            this.lbl_real_name.Size = new System.Drawing.Size(92, 25);
            this.lbl_real_name.TabIndex = 11;
            this.lbl_real_name.Text = "Nom réel";
            // 
            // tbox_formula
            // 
            this.tbox_formula.BackColor = System.Drawing.Color.White;
            this.tbox_formula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_formula.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_formula.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_formula.ForeColor = System.Drawing.Color.Gray;
            this.tbox_formula.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_formula.Location = new System.Drawing.Point(311, 426);
            this.tbox_formula.Name = "tbox_formula";
            this.tbox_formula.PasswordChar = '\0';
            this.tbox_formula.Size = new System.Drawing.Size(473, 36);
            this.tbox_formula.TabIndex = 14;
            this.tbox_formula.Text = "Renseignez une formule chimique";
            this.tbox_formula.Enter += new System.EventHandler(this.tbox_formula_Enter);
            this.tbox_formula.Leave += new System.EventHandler(this.tbox_formula_Leave);
            // 
            // lbl_formula
            // 
            this.lbl_formula.AutoSize = true;
            this.lbl_formula.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formula.Location = new System.Drawing.Point(306, 398);
            this.lbl_formula.Name = "lbl_formula";
            this.lbl_formula.Size = new System.Drawing.Size(167, 25);
            this.lbl_formula.TabIndex = 13;
            this.lbl_formula.Text = "Formule chimique";
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
            this.btn_send_to_database.Image = global::FrontEndGSBrevet.Properties.Resources.plus;
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
            this.btn_send_to_database.Size = new System.Drawing.Size(229, 67);
            this.btn_send_to_database.TabIndex = 16;
            this.btn_send_to_database.Text = "Ajouter la molecule";
            this.btn_send_to_database.Click += new System.EventHandler(this.btn_send_to_database_Click);
            // 
            // uc_CreateMolecule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_send_to_database);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.tbox_formula);
            this.Controls.Add(this.lbl_formula);
            this.Controls.Add(this.tbox_real_name);
            this.Controls.Add(this.lbl_real_name);
            this.Controls.Add(this.tbox_generic_name);
            this.Controls.Add(this.lbl_generic_name);
            this.Controls.Add(this.btn_back_to_AllMolecules);
            this.Name = "uc_CreateMolecule";
            this.Size = new System.Drawing.Size(1140, 737);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_back_to_AllMolecules;
        private Guna.UI.WinForms.GunaLabel lbl_generic_name;
        private Guna.UI.WinForms.GunaLineTextBox tbox_generic_name;
        private Guna.UI.WinForms.GunaLineTextBox tbox_real_name;
        private Guna.UI.WinForms.GunaLabel lbl_real_name;
        private Guna.UI.WinForms.GunaLineTextBox tbox_formula;
        private Guna.UI.WinForms.GunaLabel lbl_formula;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaTileButton btn_send_to_database;
    }
}
