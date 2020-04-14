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
using FrontEndGSBrevet.Views.Admin.Role.CreateUpdate;

namespace FrontEndGSBrevet.Views.Admin.Role.RoleModel
{
    public partial class uc_RoleModel : UserControl
    {
        public uc_RoleModel()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string libelle { get; set; }

        private void uc_RoleModel_Load(object sender, EventArgs e)
        {
            lbl_id.Text = id.ToString();
            lbl_libelle.Text = libelle;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(uc_MainRole.pnl_createUpdate, new uc_CreateUpdateRole { id = id, libelle = libelle });
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Voulez vous supprimer le rôle : {libelle}", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (RoleController.RoleUsed(id) && msg.Equals(DialogResult.Yes))
            {
                RoleController.Delete(id);
                MessageBox.Show($"Le rôle {libelle} a bien été supprimé", "Informational", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
