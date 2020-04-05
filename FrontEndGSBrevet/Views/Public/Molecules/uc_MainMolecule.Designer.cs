namespace FrontEndGSBrevet.Views.Public.Molecules
{
    partial class uc_MainMolecule
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
            this.pnl_tableHeader = new Guna.UI.WinForms.GunaPanel();
            this.lbl_actions = new Guna.UI.WinForms.GunaLabel();
            this.lbl_deposit_date = new Guna.UI.WinForms.GunaLabel();
            this.lbl_company = new Guna.UI.WinForms.GunaLabel();
            this.lbl_molecule = new Guna.UI.WinForms.GunaLabel();
            this.lbl_id = new Guna.UI.WinForms.GunaLabel();
            this.pnl_molecules = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.tbox_search = new Guna.UI.WinForms.GunaTextBox();
            this.btn_search = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_create_molecule = new Guna.UI.WinForms.GunaButton();
            this.btn_refresh = new Guna.UI.WinForms.GunaCircleButton();
            this.pnl_tableHeader.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_tableHeader
            // 
            this.pnl_tableHeader.Controls.Add(this.lbl_actions);
            this.pnl_tableHeader.Controls.Add(this.lbl_deposit_date);
            this.pnl_tableHeader.Controls.Add(this.lbl_company);
            this.pnl_tableHeader.Controls.Add(this.lbl_molecule);
            this.pnl_tableHeader.Controls.Add(this.lbl_id);
            this.pnl_tableHeader.Location = new System.Drawing.Point(55, 129);
            this.pnl_tableHeader.Name = "pnl_tableHeader";
            this.pnl_tableHeader.Size = new System.Drawing.Size(1010, 40);
            this.pnl_tableHeader.TabIndex = 2;
            // 
            // lbl_actions
            // 
            this.lbl_actions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actions.Location = new System.Drawing.Point(900, 10);
            this.lbl_actions.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl_actions.Name = "lbl_actions";
            this.lbl_actions.Size = new System.Drawing.Size(100, 20);
            this.lbl_actions.TabIndex = 6;
            this.lbl_actions.Text = "ACTIONS";
            this.lbl_actions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_deposit_date
            // 
            this.lbl_deposit_date.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deposit_date.Location = new System.Drawing.Point(672, 10);
            this.lbl_deposit_date.MaximumSize = new System.Drawing.Size(220, 20);
            this.lbl_deposit_date.Name = "lbl_deposit_date";
            this.lbl_deposit_date.Size = new System.Drawing.Size(220, 20);
            this.lbl_deposit_date.TabIndex = 3;
            this.lbl_deposit_date.Text = "FORMULE";
            this.lbl_deposit_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_company
            // 
            this.lbl_company.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company.Location = new System.Drawing.Point(416, 10);
            this.lbl_company.MaximumSize = new System.Drawing.Size(250, 20);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(250, 20);
            this.lbl_company.TabIndex = 2;
            this.lbl_company.Text = "NOM CHIMIQUE";
            this.lbl_company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_molecule
            // 
            this.lbl_molecule.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_molecule.Location = new System.Drawing.Point(160, 10);
            this.lbl_molecule.MaximumSize = new System.Drawing.Size(250, 20);
            this.lbl_molecule.Name = "lbl_molecule";
            this.lbl_molecule.Size = new System.Drawing.Size(250, 20);
            this.lbl_molecule.TabIndex = 1;
            this.lbl_molecule.Text = "NOM COMMERCIAL";
            this.lbl_molecule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(10, 10);
            this.lbl_id.MaximumSize = new System.Drawing.Size(140, 20);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(140, 20);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // pnl_molecules
            // 
            this.pnl_molecules.AutoScroll = true;
            this.pnl_molecules.Location = new System.Drawing.Point(55, 175);
            this.pnl_molecules.Name = "pnl_molecules";
            this.pnl_molecules.Size = new System.Drawing.Size(1040, 546);
            this.pnl_molecules.TabIndex = 3;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.tbox_search);
            this.gunaShadowPanel1.Controls.Add(this.btn_search);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(45, 13);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1040, 50);
            this.gunaShadowPanel1.TabIndex = 8;
            // 
            // tbox_search
            // 
            this.tbox_search.BaseColor = System.Drawing.Color.White;
            this.tbox_search.BorderColor = System.Drawing.Color.Silver;
            this.tbox_search.BorderSize = 0;
            this.tbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_search.FocusedBaseColor = System.Drawing.Color.White;
            this.tbox_search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_search.FocusedForeColor = System.Drawing.Color.Black;
            this.tbox_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.ForeColor = System.Drawing.Color.Gray;
            this.tbox_search.Location = new System.Drawing.Point(65, 5);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.PasswordChar = '\0';
            this.tbox_search.Size = new System.Drawing.Size(945, 40);
            this.tbox_search.TabIndex = 1;
            this.tbox_search.Text = "Rechercher...";
            this.tbox_search.TextOffsetX = 15;
            this.tbox_search.Enter += new System.EventHandler(this.tbox_search_Enter);
            this.tbox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_search_KeyPress);
            this.tbox_search.Leave += new System.EventHandler(this.tbox_search_Leave);
            // 
            // btn_search
            // 
            this.btn_search.AnimationHoverSpeed = 0.07F;
            this.btn_search.AnimationSpeed = 0.03F;
            this.btn_search.BaseColor = System.Drawing.Color.White;
            this.btn_search.BorderColor = System.Drawing.Color.Black;
            this.btn_search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_search.FocusedColor = System.Drawing.Color.Empty;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = global::FrontEndGSBrevet.Properties.Resources.search;
            this.btn_search.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_search.Location = new System.Drawing.Point(19, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_search.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_search.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.search_on;
            this.btn_search.OnPressedColor = System.Drawing.Color.Black;
            this.btn_search.Size = new System.Drawing.Size(40, 40);
            this.btn_search.TabIndex = 0;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_create_molecule
            // 
            this.btn_create_molecule.AnimationHoverSpeed = 0.07F;
            this.btn_create_molecule.AnimationSpeed = 0.03F;
            this.btn_create_molecule.BackColor = System.Drawing.Color.Transparent;
            this.btn_create_molecule.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_create_molecule.BorderColor = System.Drawing.Color.Black;
            this.btn_create_molecule.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_create_molecule.FocusedColor = System.Drawing.Color.Empty;
            this.btn_create_molecule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_molecule.ForeColor = System.Drawing.Color.White;
            this.btn_create_molecule.Image = global::FrontEndGSBrevet.Properties.Resources.plus;
            this.btn_create_molecule.ImageSize = new System.Drawing.Size(12, 12);
            this.btn_create_molecule.Location = new System.Drawing.Point(883, 77);
            this.btn_create_molecule.Name = "btn_create_molecule";
            this.btn_create_molecule.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_create_molecule.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_create_molecule.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_create_molecule.OnHoverImage = null;
            this.btn_create_molecule.OnPressedColor = System.Drawing.Color.Black;
            this.btn_create_molecule.Radius = 6;
            this.btn_create_molecule.Size = new System.Drawing.Size(182, 42);
            this.btn_create_molecule.TabIndex = 7;
            this.btn_create_molecule.Text = "CREER UNE MOLECULE";
            this.btn_create_molecule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_create_molecule.Click += new System.EventHandler(this.btn_create_molecule_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.AnimationHoverSpeed = 0.07F;
            this.btn_refresh.AnimationSpeed = 0.03F;
            this.btn_refresh.BaseColor = System.Drawing.Color.White;
            this.btn_refresh.BorderColor = System.Drawing.Color.Black;
            this.btn_refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_refresh.FocusedColor = System.Drawing.Color.Empty;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = global::FrontEndGSBrevet.Properties.Resources.refresh_off;
            this.btn_refresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_refresh.Location = new System.Drawing.Point(817, 77);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_refresh.OnHoverImage = global::FrontEndGSBrevet.Properties.Resources.refresh_on;
            this.btn_refresh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_refresh.Size = new System.Drawing.Size(42, 42);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // uc_MainMolecule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.btn_create_molecule);
            this.Controls.Add(this.pnl_molecules);
            this.Controls.Add(this.pnl_tableHeader);
            this.Name = "uc_MainMolecule";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_MainMolecule_Load);
            this.pnl_tableHeader.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_tableHeader;
        private Guna.UI.WinForms.GunaLabel lbl_actions;
        private Guna.UI.WinForms.GunaLabel lbl_deposit_date;
        private Guna.UI.WinForms.GunaLabel lbl_company;
        private Guna.UI.WinForms.GunaLabel lbl_molecule;
        private Guna.UI.WinForms.GunaLabel lbl_id;
        private System.Windows.Forms.FlowLayoutPanel pnl_molecules;
        private Guna.UI.WinForms.GunaButton btn_create_molecule;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaCircleButton btn_search;
        private Guna.UI.WinForms.GunaTextBox tbox_search;
        private Guna.UI.WinForms.GunaCircleButton btn_refresh;
    }
}
