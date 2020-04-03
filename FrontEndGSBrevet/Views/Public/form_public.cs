﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEndGSBrevet.Utils;
using FrontEndGSBrevet.Views.Shared;
using FrontEndGSBrevet.Views.Public.Companies;

namespace FrontEndGSBrevet.Views.Public
{
    public partial class form_Public : Form
    {
        public form_Public()
        {
            InitializeComponent();
            btn_menu.PerformClick();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            new SelectMenu().menuColor(this, btn_settings,Properties.Resources.settings_on, Properties.Resources.settings_off);
            SwitchUC.Switch(pnl_sideMenu, uc_SettingsMenu.Instance);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            new SelectMenu().menuColor(this, btn_menu, Properties.Resources.menu_on, Properties.Resources.menu_off);
            SwitchUC.Switch(pnl_sideMenu, uc_MainMenu.Instance);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            new SelectMenu().menuColor(this, btn_add, Properties.Resources.add_on, Properties.Resources.add_off);
            SwitchUC.Switch(pnl_sideMenu, uc_CreateMenu.Instance);
        }
    }
}
