using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEndGSBrevet.Views.Public;
using FrontEndGSBrevet.Views.Public.Contracts.CreateUpdate;
using FrontEndGSBrevet.Views.Public.Patents.CreateUpdate;
using FrontEndGSBrevet.Views.Public.Companies.CreateUpdate;
using FrontEndGSBrevet.Views.Public.Molecules.CreateUpdate;
using FrontEndGSBrevet.Views.Public.Utilities.CreateUpdate;
using FrontEndGSBrevet.Utils;

namespace FrontEndGSBrevet.Views.Shared
{
    public partial class uc_CreateMenu : UserControl
    {
        public uc_CreateMenu()
        {
            InitializeComponent();
        }
        #region load UserControl inside a panel
        private static uc_CreateMenu _instance;
        public static uc_CreateMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_CreateMenu();
                return _instance;
            }
        }
        #endregion

        private void btn_CreateContract_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, new uc_CreateUpdateContract());   
        }

        private void btn_CreatePatent_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, new uc_CreateUpdatePatent());   
        }

        private void btn_CreateCompany_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, new uc_CreateUpdateCompany());
        }

        private void btn_CreateMolecule_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, new uc_CreateUpdateMolecule());
        }

        private void btn_CreateUtility_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, new uc_CreateUpdateUtility());

        }
    }
}
