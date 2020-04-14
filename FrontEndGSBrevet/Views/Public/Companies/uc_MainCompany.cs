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
            if (btn_orderby_name.Checked)
                companies = companies.OrderBy(c => c.name);
            if (btn_orderby_city.Checked)
                companies = companies.OrderBy(c => c.city);
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

        #region textbox enter / leave / pressed
        private void tbox_search_Enter(object sender, EventArgs e)
        {
            if (tbox_search.Text == "Rechercher...")
                tbox_search.Text = "";

            tbox_search.ForeColor = Color.Black;

        }

        private void tbox_search_Leave(object sender, EventArgs e)
        {
            if (tbox_search.Text == String.Empty)
                tbox_search.Text = "Rechercher...";

            tbox_search.ForeColor = Color.Gray;

        }
        private void tbox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_search.PerformClick();
        }
        #endregion

        #region orderby 
        private void btn_orderby_name_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        private void btn_orderby_city_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }
        #endregion

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tbox_search.Text != "Rechercher...")
            {
                pnl_companies.Controls.Clear();
                var companies = CompanyController.getAll(); // .OrderBy(t => t.id).Reverse()
                companies = companies.Where(c => c.name.Contains(tbox_search.Text) || c.address.Contains(tbox_search.Text) || c.city.Contains(tbox_search.Text) || c.zip_code.Contains(tbox_search.Text));
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
            else
            {
                ReloadPanel();
            }
        }

    }
}
