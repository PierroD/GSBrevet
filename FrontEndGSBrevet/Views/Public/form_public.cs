using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEndGSBrevet.Controller;
using FrontEndGSBrevet.Utils;
using FrontEndGSBrevet.Views.Shared;
using FrontEndGSBrevet.Views.Shared.MainMenu;
using FrontEndGSBrevet.Views.Shared.CreateMenu;
using FrontEndGSBrevet.Views.Shared.SettingsMenu;
using FrontEndGSBrevet.Views.Public.Analytics;

namespace FrontEndGSBrevet.Views.Public
{
    public partial class form_Public : Form
    {
        public form_Public()
        {
            InitializeComponent();
            btn_menu.PerformClick();
            btn_initial.Text= $"{char.ToUpper(Auth.User().first_name.FirstOrDefault())}{char.ToUpper(Auth.User().last_name.FirstOrDefault())}";
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            new SelectMenu().menuColor(this, btn_menu, Properties.Resources.menu_on, Properties.Resources.menu_off);
            pnl_main.Controls.Clear();
            SwitchUC.Switch(pnl_main, new uc_MainMainMenu());
            SwitchUC.Switch(pnl_sideMenu, uc_MainMenu.Instance);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            new SelectMenu().menuColor(this, btn_add, Properties.Resources.add_on, Properties.Resources.add_off);
            pnl_main.Controls.Clear();
            SwitchUC.Switch(pnl_main, new uc_MainCreateMenu());
            SwitchUC.Switch(pnl_sideMenu, uc_CreateMenu.Instance);
        }

        private void btn_analytics_Click(object sender, EventArgs e)
        {
            new SelectMenu().menuColor(this, btn_analytics, Properties.Resources.analytics_on, Properties.Resources.analytics_off);
            pnl_sideMenu.Controls.Clear();
            SwitchUC.Switch(pnl_main, new uc_MainAnalytic());
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            new SelectMenu().menuColor(this, btn_settings,Properties.Resources.settings_on, Properties.Resources.settings_off);
            pnl_main.Controls.Clear();
            SwitchUC.Switch(pnl_main, new uc_MainSettingsMenu());
            SwitchUC.Switch(pnl_sideMenu, uc_SettingsMenu.Instance);
        }

    }
}
