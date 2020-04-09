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

namespace FrontEndGSBrevet.Views.Admin.Users.CreateUpdate
{
    public partial class uc_CreateUpdateUser : UserControl
    {
        public uc_CreateUpdateUser()
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

        private void btn_back_to_AllUsers_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void uc_CreateUpdateUser_Load(object sender, EventArgs e)
        {
            if (last_name != null)
                tbox_lastname.Text = last_name;
            if (first_name != null)
                tbox_firstname.Text = first_name;
            if (username != null)
                tbox_username.Text = username;
            if (password != null)
                tbox_password.Text = password;
            if (birth_date > dtime_birthDate.MinDate)
                dtime_birthDate.Value = birth_date;
            if (role_id != 0)
            {
                cbox_role.Items.Add(RoleController.getById(role_id).libelle);
                cbox_role.SelectedIndex = 0;
            }
        }

        private void cbox_role_Click(object sender, EventArgs e)
        {
            cbox_role.Items.Clear();
            var roles = RoleController.getAll();
            foreach (var r in roles)
            {
                cbox_role.Items.Add(r.libelle);
            }
        }

        private void btn_send_to_database_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                UserController.UpdateUser(id, tbox_lastname.Text, tbox_firstname.Text, tbox_username.Text, tbox_password.Text, dtime_birthDate.Value, RoleController.getByLibelle(cbox_role.Text));
                MessageBox.Show("L'utilisateur a été correctement mise à jour dans la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UserController.AddUser(tbox_lastname.Text, tbox_firstname.Text, tbox_username.Text, tbox_password.Text, dtime_birthDate.Value, RoleController.getByLibelle(cbox_role.Text));
                MessageBox.Show("L'utilisateur a été correctement ajoutée à la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            uc_MainUser.Instance.ReloadPanel();
            this.SendToBack();

        }

        #region enter / leave textboxes
        private void tbox_lastname_Enter(object sender, EventArgs e)
        {
            if (tbox_lastname.Text == "Renseignez un nom")
                tbox_lastname.Text = "";

            tbox_lastname.ForeColor = Color.Black;

        }

        private void tbox_lastname_Leave(object sender, EventArgs e)
        {
            if (tbox_lastname.Text == String.Empty)
                tbox_lastname.Text = "Renseignez un nom";

            tbox_lastname.ForeColor = Color.Gray;

        }

        private void tbox_firstname_Enter(object sender, EventArgs e)
        {
            if (tbox_firstname.Text == "Renseignez un prénom")
                tbox_firstname.Text = "";

            tbox_firstname.ForeColor = Color.Black;

        }

        private void tbox_firstname_Leave(object sender, EventArgs e)
        {
            if (tbox_firstname.Text == String.Empty)
                tbox_firstname.Text = "Renseignez un prénom";

            tbox_firstname.ForeColor = Color.Gray;


        }

        private void tbox_username_Enter(object sender, EventArgs e)
        {
            if (tbox_username.Text == "Renseignez un identifiant")
                tbox_username.Text = "";

            tbox_username.ForeColor = Color.Black;
        }

        private void tbox_username_Leave(object sender, EventArgs e)
        {
            if (tbox_firstname.Text == String.Empty)
                tbox_firstname.Text = "Renseignez un identifiant";

            tbox_firstname.ForeColor = Color.Gray;
        }

        private void tbox_password_Enter(object sender, EventArgs e)
        {
            if (tbox_password.Text == "Renseignez un mot de passe")
                tbox_password.Text = "";

            tbox_password.ForeColor = Color.Black;
        }

        private void tbox_password_Leave(object sender, EventArgs e)
        {
            if (tbox_password.Text == String.Empty)
                tbox_password.Text = "Renseignez un mot de passe";

            tbox_password.ForeColor = Color.Gray;
        }
        #endregion

    }
}
