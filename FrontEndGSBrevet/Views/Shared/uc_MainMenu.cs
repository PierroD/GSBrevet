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
using FrontEndGSBrevet.Views.Public.Patents;
using FrontEndGSBrevet.Views.Public.Contracts;
using FrontEndGSBrevet.Utils;

namespace FrontEndGSBrevet.Views.Shared
{
    public partial class uc_MainMenu : UserControl
    {
        public uc_MainMenu()
        {
            InitializeComponent();
        }
        #region load UserControl inside a panel
        private static uc_MainMenu _instance;
        public static uc_MainMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainMenu();
                return _instance;
            }
        }
        #endregion

        private void btn_AllPatents_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, uc_MainPatent.Instance); // on charge tous les brevets
        }

        private void btn_AllContracts_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, uc_MainContract.Instance); // on charge tous les contrats
        }
    }
}
