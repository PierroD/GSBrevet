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

namespace FrontEndGSBrevet.Views.Public.Profil
{
    public partial class uc_MainProfil : UserControl
    {
        public uc_MainProfil()
        {
            InitializeComponent();
        }

        private void uc_MainProfil_Load(object sender, EventArgs e)
        {
            lbl_lastname.Text = Auth.User().last_name;
            lbl_firstname.Text = Auth.User().first_name;
            lbl_username.Text = Auth.User().username;
            lbl_birthDate.Text = Auth.User().birth_date.ToString();
            lbl_role.Text = Auth.Role().libelle;
        }
    }
}
