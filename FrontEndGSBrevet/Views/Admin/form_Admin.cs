using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEndGSBrevet.Views.Admin.UserModel;
using FrontEndGSBrevet.Utils;
using BackEndGSBrevet.Controller;

namespace FrontEndGSBrevet.Views.Admin
{
    public partial class form_Admin : Form
    {
        public form_Admin()
        {
            InitializeComponent();
        }

        private void form_Admin_Load(object sender, EventArgs e)
        {
            var users = UserController.getAll();
            foreach(var u in users)
            {
                pnl_users.Controls.Add(new uc_UserModel
                {
                    id = u.id,
                    last_name = u.last_name,
                    first_name = u.first_name,
                    birth_date = u.birth_date,
                    username = u.username,
                    password = u.password,
                   // role_id = u.,
                });
            }
        }
    }
}
