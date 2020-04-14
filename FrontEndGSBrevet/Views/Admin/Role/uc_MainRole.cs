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


namespace FrontEndGSBrevet.Views.Admin.Role
{
    public partial class uc_MainRole : UserControl
    {
        public uc_MainRole()
        {
            InitializeComponent();
        }

        private void uc_MainRole_Load(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        public void ReloadPanel()
        {
            pnl_roles.Controls.Clear();
            var roles = RoleController.getAll();
            foreach(var r in roles)
            {
                pnl_roles.Controls.Add(new uc_RoleModel { 
                id = r.id,
                libelle = r.libelle
                });
            }
        }
    }
}
