using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEndGSBrevet.Utils;
using FrontEndGSBrevet.Views.Public.Contracts.CreateUpdate;
using BackEndGSBrevet.Controller;

namespace FrontEndGSBrevet.Views.Public.Contracts.ContractModel
{
    public partial class uc_ContractModel : UserControl
    {
        public uc_ContractModel()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public int company_id { get; set; }
        public int patent_id { get; set; }
        public DateTime create_date { get; set; }
        public int duration { get; set; }
        public double price { get; set; }

        private void uc_ContractModel_Load(object sender, EventArgs e)
        {
            lbl_id.Text = id.ToString();
            lbl_company.Text = CompanyController.getById(company_id).name;
            lbl_patent.Text = PatentController.getById(patent_id).number;
            lbl_create_date.Text = create_date.ToString();
            lbl_duration.Text = duration.ToString() + "an(s)";
            lbl_price.Text = price.ToString().Replace('.', ',') + "€";
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, new uc_CreateUpdateContract { id = id, company_id = company_id, patent_id = patent_id, create_date = create_date, duration = duration, price = price });
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ContractController.Delete(id);
            uc_MainContract.Instance.ReloadPanel();
        }

    }
}
