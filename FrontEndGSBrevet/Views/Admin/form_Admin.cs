using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEndGSBrevet.Views.Admin.Users;
using FrontEndGSBrevet.Views.Admin.Role;
using FrontEndGSBrevet.Utils;
using BackEndGSBrevet.Controller;


namespace FrontEndGSBrevet.Views.Admin
{
    public partial class form_Admin : Form
    {
        Form parentForm;
        public form_Admin(Form pform)
        {
            this.parentForm = pform;
            InitializeComponent();
            btn_initial.Text = $"{char.ToUpper(Auth.User().first_name.FirstOrDefault())}{char.ToUpper(Auth.User().last_name.FirstOrDefault())}";
            btn_users.PerformClick();
        }

        private void form_Admin_Load(object sender, EventArgs e)
        {
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(pnl_main, new uc_MainUser());
        }

        private void btn_roles_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(pnl_main, new uc_MainRole());
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Auth.destroy();
            parentForm.Visible = true;
        }
    }
}
