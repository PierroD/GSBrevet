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
using FrontEndGSBrevet.Utils;
using FrontEndGSBrevet.Views.Public.Utilities.UtilityModel;
using FrontEndGSBrevet.Views.Public.Utilities.CreateUpdate;

namespace FrontEndGSBrevet.Views.Public.Utilities
{
    public partial class uc_MainUtility : UserControl
    {
        public uc_MainUtility()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_MainUtility _instance;
        public static uc_MainUtility Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainUtility();
                return _instance;
            }
        }
        #endregion


        private void uc_MainUtility_Load(object sender, EventArgs e)
        {
            ReloadPanel();
        }
        public void ReloadPanel()
        {
            pnl_utilities.Controls.Clear();
            var utilities = UtilityController.getAll(); // .OrderBy(t => t.id).Reverse()
            foreach (var u in utilities)
            {
                pnl_utilities.Controls.Add(new uc_UtilityModel
                {
                    id = u.id,
                    molecule_id = u.molecule_id,
                    name = u.name,
                    description = u.description
                });
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        private void btn_create_utility_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, uc_CreateUpdateUtility.Instance);   
        }
    }
}
