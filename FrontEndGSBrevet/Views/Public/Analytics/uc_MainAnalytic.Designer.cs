namespace FrontEndGSBrevet.Views.Public.Analytics
{
    partial class uc_MainAnalytic
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
            this.pieChart_ContractsByCompany = new LiveCharts.WinForms.PieChart();
            this.lbl_title_ContractsByCompany = new Guna.UI.WinForms.GunaLabel();
            this.lbl_title_UtilitiesByMolecule = new Guna.UI.WinForms.GunaLabel();
            this.pieChart_UtilitiesByMolecule = new LiveCharts.WinForms.PieChart();
            this.cartesianChart_MoneyByTime = new LiveCharts.WinForms.CartesianChart();
            this.lbl_title_MoneyByTime = new Guna.UI.WinForms.GunaLabel();
            this.btn_refreshData = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // pieChart_ContractsByCompany
            // 
            this.pieChart_ContractsByCompany.BackColor = System.Drawing.Color.White;
            this.pieChart_ContractsByCompany.ForeColor = System.Drawing.Color.White;
            this.pieChart_ContractsByCompany.Location = new System.Drawing.Point(3, 424);
            this.pieChart_ContractsByCompany.Name = "pieChart_ContractsByCompany";
            this.pieChart_ContractsByCompany.Size = new System.Drawing.Size(550, 310);
            this.pieChart_ContractsByCompany.TabIndex = 0;
            this.pieChart_ContractsByCompany.Text = "pieChart1";
            // 
            // lbl_title_ContractsByCompany
            // 
            this.lbl_title_ContractsByCompany.AutoSize = true;
            this.lbl_title_ContractsByCompany.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_ContractsByCompany.Location = new System.Drawing.Point(137, 401);
            this.lbl_title_ContractsByCompany.Name = "lbl_title_ContractsByCompany";
            this.lbl_title_ContractsByCompany.Size = new System.Drawing.Size(254, 20);
            this.lbl_title_ContractsByCompany.TabIndex = 2;
            this.lbl_title_ContractsByCompany.Text = "Le nombre de contrats par entreprise";
            // 
            // lbl_title_UtilitiesByMolecule
            // 
            this.lbl_title_UtilitiesByMolecule.AutoSize = true;
            this.lbl_title_UtilitiesByMolecule.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_UtilitiesByMolecule.Location = new System.Drawing.Point(743, 401);
            this.lbl_title_UtilitiesByMolecule.Name = "lbl_title_UtilitiesByMolecule";
            this.lbl_title_UtilitiesByMolecule.Size = new System.Drawing.Size(248, 20);
            this.lbl_title_UtilitiesByMolecule.TabIndex = 3;
            this.lbl_title_UtilitiesByMolecule.Text = "Le nombre de utilitées par molécule";
            // 
            // pieChart_UtilitiesByMolecule
            // 
            this.pieChart_UtilitiesByMolecule.BackColor = System.Drawing.Color.White;
            this.pieChart_UtilitiesByMolecule.ForeColor = System.Drawing.Color.White;
            this.pieChart_UtilitiesByMolecule.Location = new System.Drawing.Point(574, 424);
            this.pieChart_UtilitiesByMolecule.Name = "pieChart_UtilitiesByMolecule";
            this.pieChart_UtilitiesByMolecule.Size = new System.Drawing.Size(550, 310);
            this.pieChart_UtilitiesByMolecule.TabIndex = 4;
            this.pieChart_UtilitiesByMolecule.Text = "pieChart2";
            // 
            // cartesianChart_MoneyByTime
            // 
            this.cartesianChart_MoneyByTime.BackColor = System.Drawing.Color.White;
            this.cartesianChart_MoneyByTime.Location = new System.Drawing.Point(3, 72);
            this.cartesianChart_MoneyByTime.Name = "cartesianChart_MoneyByTime";
            this.cartesianChart_MoneyByTime.Size = new System.Drawing.Size(1134, 316);
            this.cartesianChart_MoneyByTime.TabIndex = 5;
            this.cartesianChart_MoneyByTime.Text = "cartesianChart1";
            // 
            // lbl_title_MoneyByTime
            // 
            this.lbl_title_MoneyByTime.AutoSize = true;
            this.lbl_title_MoneyByTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_MoneyByTime.Location = new System.Drawing.Point(452, 40);
            this.lbl_title_MoneyByTime.Name = "lbl_title_MoneyByTime";
            this.lbl_title_MoneyByTime.Size = new System.Drawing.Size(216, 20);
            this.lbl_title_MoneyByTime.TabIndex = 6;
            this.lbl_title_MoneyByTime.Text = "Revenues en fonction du temps";
            // 
            // btn_refreshData
            // 
            this.btn_refreshData.AnimationHoverSpeed = 0.07F;
            this.btn_refreshData.AnimationSpeed = 0.03F;
            this.btn_refreshData.BackColor = System.Drawing.Color.Transparent;
            this.btn_refreshData.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_refreshData.BorderColor = System.Drawing.Color.Black;
            this.btn_refreshData.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_refreshData.FocusedColor = System.Drawing.Color.Empty;
            this.btn_refreshData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreshData.ForeColor = System.Drawing.Color.White;
            this.btn_refreshData.Image = global::FrontEndGSBrevet.Properties.Resources.refresh_on;
            this.btn_refreshData.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_refreshData.Location = new System.Drawing.Point(965, 7);
            this.btn_refreshData.Name = "btn_refreshData";
            this.btn_refreshData.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.btn_refreshData.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_refreshData.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_refreshData.OnHoverImage = null;
            this.btn_refreshData.OnPressedColor = System.Drawing.Color.Black;
            this.btn_refreshData.Radius = 5;
            this.btn_refreshData.Size = new System.Drawing.Size(151, 44);
            this.btn_refreshData.TabIndex = 7;
            this.btn_refreshData.Text = "REFRESH DATAS";
            this.btn_refreshData.Click += new System.EventHandler(this.btn_refreshData_Click);
            // 
            // uc_MainAnalytic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_refreshData);
            this.Controls.Add(this.lbl_title_MoneyByTime);
            this.Controls.Add(this.cartesianChart_MoneyByTime);
            this.Controls.Add(this.pieChart_UtilitiesByMolecule);
            this.Controls.Add(this.lbl_title_UtilitiesByMolecule);
            this.Controls.Add(this.lbl_title_ContractsByCompany);
            this.Controls.Add(this.pieChart_ContractsByCompany);
            this.Name = "uc_MainAnalytic";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_MainAnalytic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart_ContractsByCompany;
        private Guna.UI.WinForms.GunaLabel lbl_title_ContractsByCompany;
        private Guna.UI.WinForms.GunaLabel lbl_title_UtilitiesByMolecule;
        private LiveCharts.WinForms.PieChart pieChart_UtilitiesByMolecule;
        private LiveCharts.WinForms.CartesianChart cartesianChart_MoneyByTime;
        private Guna.UI.WinForms.GunaLabel lbl_title_MoneyByTime;
        private Guna.UI.WinForms.GunaButton btn_refreshData;
    }
}
