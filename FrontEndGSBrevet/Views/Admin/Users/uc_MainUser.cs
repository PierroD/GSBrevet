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
using FrontEndGSBrevet.Views.Admin.Users.UserModel;
using FrontEndGSBrevet.Views.Admin.Users.CreateUpdate;
using FrontEndGSBrevet.Utils;

namespace FrontEndGSBrevet.Views.Admin.Users
{
    public partial class uc_MainUser : UserControl
    {
        public uc_MainUser()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_MainUser _instance;
        public static uc_MainUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainUser();
                return _instance;
            }
        }
        #endregion


        private void uc_MainUser_Load(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        public void ReloadPanel()
        {
            pnl_users.Controls.Clear();
            var users = UserController.getAll();
            if (btn_orderby_lastName.Checked)
                users = users.OrderBy(u => u.last_name);
            if (btn_orderby_firstName.Checked)
                users = users.OrderBy(u => u.first_name);
            if (btn_orderby_username.Checked)
                users = users.OrderBy(u => u.username);

            foreach (var u in users)
            {
                pnl_users.Controls.Add(new uc_UserModel
                {
                    id = u.id,
                    last_name = u.last_name,
                    first_name = u.first_name,
                    birth_date = u.birth_date,
                    username = u.username,
                    password = u.password,
                    role_id = u.role_id,
                });
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        #region textbox enter / leave / pressed
        private void tbox_search_Enter(object sender, EventArgs e)
        {
            if (tbox_search.Text == "Rechercher...")
                tbox_search.Text = "";

            tbox_search.ForeColor = Color.Black;

        }

        private void tbox_search_Leave(object sender, EventArgs e)
        {
            if (tbox_search.Text == String.Empty)
                tbox_search.Text = "Rechercher...";

            tbox_search.ForeColor = Color.Gray;

        }
        private void tbox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btn_search.PerformClick();
        }
        #endregion

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tbox_search.Text != "Rechercher...")
            {
                pnl_users.Controls.Clear();
                var users = UserController.getAll(); // .OrderBy(t => t.id).Reverse()
                users = users.Where(u => u.last_name.Contains(tbox_search.Text) || u.first_name.Contains(tbox_search.Text) || u.username.Contains(tbox_search.Text));
                foreach (var u in users)
                {
                    pnl_users.Controls.Add(new uc_UserModel
                    {
                        id = u.id,
                        last_name = u.last_name,
                        first_name = u.first_name,
                        birth_date = u.birth_date,
                        username = u.username,
                        password = u.password,
                        role_id = u.role_id,
                    });
                }
            }
            else
                ReloadPanel();

        }

        private void btn_create_user_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Admin.pnl_main, new uc_CreateUpdateUser());
        }

        #region orderby
        private void btn_orderby_lastName_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        private void btn_orderby_firstName_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        private void btn_orderby_username_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }
        #endregion
    }
}
