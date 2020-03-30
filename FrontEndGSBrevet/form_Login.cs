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
using BackEndGSBrevet.Models;
using FrontEndGSBrevet.Views.Public;

namespace FrontEndGSBrevet
{
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();
        }

        #region show/hide password
        private bool visible_password = true;
        private void pbox_showPassword_Click(object sender, EventArgs e)
        {
            if(visible_password)
            {
                pbox_showPassword.Image = Properties.Resources.icons8_hide_30px;
                tbox_password.UseSystemPasswordChar = true;
            }
            else
            {
                pbox_showPassword.Image = Properties.Resources.icons8_eye_30px;
                tbox_password.UseSystemPasswordChar = false;
            }
            visible_password = !visible_password;
        }
        #endregion

        #region empty/fill textbox
        private void tbox_username_Enter(object sender, EventArgs e)
        {
            if(tbox_username.Text == "Identifiant")
            tbox_username.Text = "";
        }

        private void tbox_username_Leave(object sender, EventArgs e)
        {
            if (tbox_username.Text == String.Empty)
                tbox_username.Text = "Identifiant";
        }

        private void tbox_password_Enter(object sender, EventArgs e)
        {
            if(tbox_password.Text == "Mot de passe")
            tbox_password.Text = "";
        }

        private void tbox_password_Leave(object sender, EventArgs e)
        {
            if (tbox_password.Text == String.Empty)
                tbox_password.Text = "Mot de passe";
        }

        #endregion

        #region Login 
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tbox_username.Text, password = tbox_password.Text;
            var request = UserController.signIn(username, password);
            if(request.Item1) // true or false
            {
                switch(request.Item3)
                {
                    case 1:
                        new form_Public().Show();
                        this.Visible = false;
                        break;
                    case 2:
                        //admin form
                        break;
                    default:
                        //public form
                        break;
                }
            }
            else
                MessageBox.Show(request.Item2, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
