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
using FrontEndGSBrevet.Views.Public.Utilities;
using FrontEndGSBrevet.Views.Public.Utilities.CreateUpdate;
using FrontEndGSBrevet.Utils;

namespace FrontEndGSBrevet.Views.Public.Utilities.UtilityModel
{
    public partial class uc_UtilityModel : UserControl
    {
        public uc_UtilityModel()
        {
            InitializeComponent();
        }

        #region structure
        public int id { get; set; }
        public int molecule_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        #endregion

        private void uc_UtilityModel_Load(object sender, EventArgs e)
        {
            lbl_id.Text = id.ToString();
            lbl_molecule.Text = MoleculeController.getById(molecule_id).generic_name;
            lbl_name.Text = name;
            lbl_description.Text = description;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, new uc_CreateUpdateUtility { id = id, molecule_id = molecule_id, name = name, description = description});
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            UtilityController.Delete(id);
            uc_MainUtility.Instance.ReloadPanel();
            this.SendToBack();
        }
    }
}
