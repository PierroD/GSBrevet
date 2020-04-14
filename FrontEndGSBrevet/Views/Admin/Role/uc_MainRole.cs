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
using FrontEndGSBrevet.Views.Admin.Role.RoleModel;
using FrontEndGSBrevet.Views.Admin.Role.CreateUpdate;
using FrontEndGSBrevet.Utils;


namespace FrontEndGSBrevet.Views.Admin.Role
{
    public partial class uc_MainRole : UserControl
    {
        public uc_MainRole()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_MainRole _instance;
        public static uc_MainRole Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainRole();
                return _instance;
            }
        }
        #endregion
        
        private void uc_MainRole_Load(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        public void ReloadPanel()
        {
            pnl_roles.Controls.Clear();
            var roles = RoleController.getAll();
            foreach (var r in roles)
            {
                pnl_roles.Controls.Add(new uc_RoleModel
                {
                    id = r.id,
                    libelle = r.libelle
                });
            }
        }

        private void btn_create_role_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(pnl_createUpdate, new uc_CreateUpdateRole());
        }
    }
}
