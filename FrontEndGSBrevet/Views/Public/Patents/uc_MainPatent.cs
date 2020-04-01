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
using FrontEndGSBrevet.Views.Public.Patents.PatentModel;

namespace FrontEndGSBrevet.Views.Public.Patents
{
    public partial class uc_MainPatent : UserControl
    {
        public uc_MainPatent()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_MainPatent _instance;
        public static uc_MainPatent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainPatent();
                return _instance;
            }
        }
        #endregion

        private void uc_MainPatent_Load(object sender, EventArgs e)
        {
            var patents = PatentController.getAll(); // .OrderBy(t => t.id).Reverse()
            foreach (var p in patents)
            {
                var molecule = MoleculeController.getById(p.molecule_id);
                var company = CompanyController.getById(p.company_id);
                pnl_patents.Controls.Add(new uc_PatentModel
                {
                    number = p.number,
                    molecule = molecule.generic_name,
                    company = company.name,
                    deposit_date = p.deposit_date,
                    duration = p.duration,
                    country = p.country
                }); 
            }

        }
    }
}
