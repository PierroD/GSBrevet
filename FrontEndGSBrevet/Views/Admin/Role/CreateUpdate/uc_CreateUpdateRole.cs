using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGSBrevet.Views.Admin.Role.CreateUpdate
{
    public partial class uc_CreateUpdateRole : UserControl
    {
        public uc_CreateUpdateRole()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string libelle { get; set; }

        #region textboxes enter/leave/pressed
        private void tbox_cu_libelle_Enter(object sender, EventArgs e)
        {
            if (tbox_cu_libelle.Text == "Renseignez un nom de rôle")
                tbox_cu_libelle.Text = String.Empty;

            tbox_cu_libelle.ForeColor = Color.Black;

        }

        private void tbox_cu_libelle_Leave(object sender, EventArgs e)
        {
            if (tbox_cu_libelle.Text == String.Empty)
                tbox_cu_libelle.Text = "Renseignez un nom de rôle";

            tbox_cu_libelle.ForeColor = Color.Gray;
        }

        private void tbox_cu_libelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btn_send_to_database.PerformClick();
        }
        #endregion

        private void btn_send_to_database_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                //  UserController.UpdateUser(id, tbox_lastname.Text, tbox_firstname.Text, tbox_username.Text, tbox_password.Text, dtime_birthDate.Value, RoleController.getByLibelle(cbox_role.Text));
                MessageBox.Show("L'utilisateur a été correctement mise à jour dans la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // UserController.AddUser(tbox_lastname.Text, tbox_firstname.Text, tbox_username.Text, tbox_password.Text, dtime_birthDate.Value, RoleController.getByLibelle(cbox_role.Text));
                MessageBox.Show("L'utilisateur a été correctement ajoutée à la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            uc_MainRole.Instance.ReloadPanel();
            this.SendToBack();

        }

        private void uc_CreateUpdateRole_Load(object sender, EventArgs e)
        {
            lbl_cu_libelle.Text = libelle;
        }
    }
}
