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
using FrontEndGSBrevet.Views.Admin.Users.CreateUpdate;

namespace FrontEndGSBrevet.Views.Admin.Users.UserModel
{
    public partial class uc_UserModel : UserControl
    {
        public uc_UserModel()
        {
            InitializeComponent();
        }

        #region structure
        public int id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public DateTime birth_date { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int role_id { get; set; }
        #endregion

        private void uc_UserModel_Load(object sender, EventArgs e)
        {
            lbl_id.Text = id.ToString();
            lbl_lastName.Text = last_name;
            lbl_firstName.Text = first_name;
            lbl_username.Text = username;
            lbl_birthDate.Text = RoleController.getById(role_id).libelle;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Admin.pnl_main, new uc_CreateUpdateUser { id = id, last_name = last_name, first_name = first_name, username = username, password = password, birth_date = birth_date, role_id = role_id });
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Voulez vous vraiment supprimer l'utilisateur : {last_name} {first_name}", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg.Equals(DialogResult.Yes))
            {
                UserController.Delete(id);
                MessageBox.Show($"L'utilisateur {last_name} {first_name} a bien été supprimé", "Informational", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
