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
            var contracts = ContractController.getAll(); // .OrderBy(t => t.id).Reverse()
            foreach (var c in contracts)
            {
                var company = CompanyController.getById(c.company_id);
                var patent = PatentController.getById(c.patent_id);
                pnl_contracts.Controls.Add(new uc_ContractModel
                {
                    id = c.id,
                    company = company.name,
                    patent = patent.number,
                    create_date = c.create_date,
                    duration = c.duration,
                    price = c.price
                });
            }
        }
    }
}
