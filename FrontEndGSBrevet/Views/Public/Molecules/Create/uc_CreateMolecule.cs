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
using FrontEndGSBrevet.Views.Public.Molecules;

namespace FrontEndGSBrevet.Views.Public.Molecules.Create
{
    public partial class uc_CreateMolecule : UserControl
    {
        public uc_CreateMolecule()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_CreateMolecule _instance;
        public static uc_CreateMolecule Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_CreateMolecule();
                return _instance;
            }
        }

        #endregion
        private void btn_back_to_AllMolecules_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btn_send_to_database_Click(object sender, EventArgs e)
        {
            if (tbox_generic_name.Text != String.Empty && tbox_real_name.Text != String.Empty && tbox_formula.Text != String.Empty)
                MoleculeController.AddMolecule(tbox_generic_name.Text, tbox_real_name.Text, tbox_formula.Text);

            MessageBox.Show("La molécule a été correctement ajoutée à la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uc_MainMolecule.Instance.ReloadPanel();
            this.SendToBack();
        }

        #region textbox enter/leave
        private void tbox_generic_name_Enter(object sender, EventArgs e)
        {
            if (tbox_generic_name.Text == "Renseignez un nom commercial")
                tbox_generic_name.Text = "";

            tbox_generic_name.ForeColor = Color.Black;
        }

        private void tbox_generic_name_Leave(object sender, EventArgs e)
        {
            if (tbox_generic_name.Text == String.Empty)
                tbox_generic_name.Text = "Renseignez un nom commercial";

            tbox_generic_name.ForeColor = Color.Gray;
        }

        private void tbox_real_name_Enter(object sender, EventArgs e)
        {
            if (tbox_real_name.Text == "Renseignez un vrai nom")
                tbox_real_name.Text = "";

            tbox_real_name.ForeColor = Color.Black;
        }

        private void tbox_real_name_Leave(object sender, EventArgs e)
        {
            if (tbox_real_name.Text == String.Empty)
                tbox_real_name.Text = "Renseignez un vrai nom";

            tbox_real_name.ForeColor = Color.Gray;
        }

        private void tbox_formula_Enter(object sender, EventArgs e)
        {
            if (tbox_formula.Text == "Renseignez une formule chimique")
                tbox_formula.Text = "";

            tbox_formula.ForeColor = Color.Black;

        }

        private void tbox_formula_Leave(object sender, EventArgs e)
        {
            if (tbox_formula.Text == String.Empty)
                tbox_formula.Text = "Renseignez une formule chimique";

            tbox_formula.ForeColor = Color.Black;
        }
        #endregion
    }
}
