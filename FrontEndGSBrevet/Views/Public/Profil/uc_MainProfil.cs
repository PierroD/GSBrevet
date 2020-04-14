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
            btn_initial.Text = $"{char.ToUpper(Auth.User().first_name.FirstOrDefault())}{char.ToUpper(Auth.User().last_name.FirstOrDefault())}";
            lbl_lastname.Text = "Nom : " + Auth.User().last_name;
            lbl_firstname.Text = "Prénom : " + Auth.User().first_name;
            lbl_username.Text = "Nom d'utilisateur : " + Auth.User().username;
            lbl_birthDate.Text = "Date de naissance : " + Auth.User().birth_date.ToString();
            lbl_role.Text = "Rôle : " + Auth.Role().libelle;
        }
    }
}
