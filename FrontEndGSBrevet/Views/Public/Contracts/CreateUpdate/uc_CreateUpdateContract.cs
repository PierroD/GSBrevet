using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEndGSBrevet.Controller;

namespace FrontEndGSBrevet.Views.Public.Contracts.CreateUpdate
{
    public partial class uc_CreateUpdateContract : UserControl
    {
        public uc_CreateUpdateContract()
        {
            InitializeComponent();
        }

        #region structure
        public int id { get; set; }
        public int company_id { get; set; }
        public int patent_id { get; set; }
        public DateTime create_date { get; set; }
        public int duration { get; set; }
        public double price { get; set; }
        #endregion

        #region load UserControl inside a panel
        private static uc_CreateUpdateContract _instance;
        public static uc_CreateUpdateContract Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_CreateUpdateContract();
                return _instance;
            }
        }

        #endregion

        #region price textboxes
        private void tbox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tbox_price.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }
        #endregion

        #region combobox load items
        private void cbox_patents_Click(object sender, EventArgs e)
        {
            cbox_patents.Items.Clear();
            var patents = PatentController.getAll();
            foreach (var patent in patents)
            {
                cbox_patents.Items.Add(patent.number);
            }
        }

        private void cbox_companies_Click(object sender, EventArgs e)
        {
            cbox_companies.Items.Clear();
            var companies = CompanyController.getAll();
            foreach (var company in companies)
            {
                cbox_companies.Items.Add(company.name);
            }
        }
        #endregion

        private void btn_back_to_AllContracts_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btn_send_to_database_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                ContractController.UpdateContract(id, CompanyController.getByName(cbox_companies.Text), PatentController.getByNumber(cbox_patents.Text), dtime_deposit_date.Value, (int)nbox_duration.Value, Convert.ToDouble(tbox_price.Text));
                MessageBox.Show("Le contrat a été correctement mise à jour dans la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ContractController.AddContract(CompanyController.getByName(cbox_companies.Text), PatentController.getByNumber(cbox_patents.Text), dtime_deposit_date.Value, (int)nbox_duration.Value, Convert.ToDouble(tbox_price.Text.Replace('.', ',')));
                MessageBox.Show("Le contrat a été correctement ajoutée à la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            uc_MainContract.Instance.ReloadPanel();
            this.SendToBack();

        }

        private void uc_CreateUpdateContract_Load(object sender, EventArgs e)
        {
            if (company_id != 0)
            {
                cbox_companies.Items.Add(CompanyController.getById(company_id).name);
                cbox_companies.SelectedIndex = 0;
            }
            if (patent_id != 0)
            {
                cbox_patents.Items.Add(PatentController.getById(patent_id).number);
                cbox_patents.SelectedIndex = 0;
            }
            if (create_date > dtime_deposit_date.MinDate)
                dtime_deposit_date.Value = create_date;
            if (duration != 0)
                nbox_duration.Value = duration;
            if (price != 00.00)
                tbox_price.Text = price.ToString();

        }
    }
}
