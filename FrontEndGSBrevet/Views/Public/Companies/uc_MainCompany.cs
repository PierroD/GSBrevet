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
using FrontEndGSBrevet.Views.Public.Companies.CompanyModel;
using FrontEndGSBrevet.Views.Public.Companies.CreateUpdate;
using FrontEndGSBrevet.Utils;

namespace FrontEndGSBrevet.Views.Public.Companies
{
    public partial class uc_MainCompany : UserControl
    {
        public uc_MainCompany()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_MainCompany _instance;
        public static uc_MainCompany Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainCompany();
                return _instance;
            }
        }
        #endregion

        private void uc_MainCompany_Load(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        public void ReloadPanel()
        {
            pnl_companies.Controls.Clear();
            var companies = CompanyController.getAll(); // .OrderBy(t => t.id).Reverse()
            foreach (var c in companies)
            {
                pnl_companies.Controls.Add(new uc_CompanyModel
                {
                    id = c.id,
                    name = c.name,
                    address = c.address,
                    city = c.city,
                    zip_code = c.zip_code
                });
            }
        }

        private void btn_create_company_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, uc_CreateUpdateCompany.Instance);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }
    }
}
