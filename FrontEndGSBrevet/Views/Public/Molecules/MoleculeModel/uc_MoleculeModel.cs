using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEndGSBrevet.Views.Public.Molecules.CreateUpdate;
using FrontEndGSBrevet.Utils;
using BackEndGSBrevet.Controller;

namespace FrontEndGSBrevet.Views.Public.Molecules.MoleculeModel
{
    public partial class uc_MoleculeModel : UserControl
    {
        public uc_MoleculeModel()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string generic_name { get; set; }
        public string real_name { get; set; }
        public string formula { get; set; }

        private void uc_MoleculeModel_Load(object sender, EventArgs e)
        {
            lbl_id.Text = id.ToString();
            lbl_generic_name.Text = generic_name;
            lbl_real_name.Text = real_name;
            lbl_formula.Text = formula;

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, new uc_CreateUpdateMolecule { id = id, generic_name = generic_name, real_name = real_name, formula = formula });
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (MoleculeController.MoleculeUsed(id))
            {
                MoleculeController.Delete(id);
                uc_MainMolecule.Instance.ReloadPanel();
            }
            else
                MessageBox.Show("La molécule est utilisée par un brevet ou par une utilitée", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
