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
using FrontEndGSBrevet.Views.Public;
using FrontEndGSBrevet.Views.Public.Settings;

namespace FrontEndGSBrevet.Views.Shared
{
    public partial class uc_SettingsMenu : UserControl
    {
        public uc_SettingsMenu()
        {
            InitializeComponent();
        }
        #region load UserControl inside a panel
        private static uc_SettingsMenu _instance;
        public static uc_SettingsMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_SettingsMenu();
                return _instance;
            }
        }
        #endregion

        private void btn_options_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, uc_Options.Instance); // charger les options
        }
    }
}
