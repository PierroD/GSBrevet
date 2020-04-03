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
using FrontEndGSBrevet.Views.Public.Contracts.ContractModel;
using FrontEndGSBrevet.Views.Public.Contracts.CreateUpdate;
using FrontEndGSBrevet.Utils;

namespace FrontEndGSBrevet.Views.Public.Contracts
{
    public partial class uc_MainContract : UserControl
    {
        public uc_MainContract()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_MainContract _instance;
        public static uc_MainContract Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainContract();
                return _instance;
            }
        }

        #endregion

        private void uc_MainContract_Load(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        public void ReloadPanel()
        {
            pnl_contracts.Controls.Clear();
            var contracts = ContractController.getAll(); // .OrderBy(t => t.id).Reverse()
            foreach (var c in contracts)
            {
                pnl_contracts.Controls.Add(new uc_ContractModel
                {
                    id = c.id,
                    company_id = c.company_id,
                    patent_id = c.patent_id,
                    create_date = c.create_date,
                    duration = c.duration,
                    price = c.price
                });
            }
        }

        private void btn_create_contract_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, uc_CreateUpdateContract.Instance);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }
    }
}
