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
using FrontEndGSBrevet.Views.Public.Molecules.MoleculeModel;
using FrontEndGSBrevet.Views.Public.Molecules.CreateUpdate;
using FrontEndGSBrevet.Utils;

namespace FrontEndGSBrevet.Views.Public.Molecules
{
    public partial class uc_MainMolecule : UserControl
    {
        public uc_MainMolecule()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_MainMolecule _instance;
        public static uc_MainMolecule Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainMolecule();
                return _instance;
            }
        }

        #endregion

        private void uc_MainMolecule_Load(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        public void ReloadPanel()
        {
            pnl_molecules.Controls.Clear();
            var molecules = MoleculeController.getAll();
            foreach (var m in molecules)
            {
                pnl_molecules.Controls.Add(new uc_MoleculeModel
                {
                    id = m.id,
                    generic_name = m.generic_name,
                    real_name = m.real_name,
                    formula = m.formula
                });
            }
        }

        private void btn_create_molecule_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, uc_CreateUpdateMolecule.Instance);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        #region textbox enter / leave / pressed
        private void tbox_search_Enter(object sender, EventArgs e)
        {
            if (tbox_search.Text == "Rechercher...")
                tbox_search.Text = "";

            tbox_search.ForeColor = Color.Black;

        }

        private void tbox_search_Leave(object sender, EventArgs e)
        {
            if (tbox_search.Text == String.Empty)
                tbox_search.Text = "Rechercher...";

            tbox_search.ForeColor = Color.Gray;

        }
        private void tbox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_search.PerformClick();
        }
        #endregion

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tbox_search.Text != "Rechercher...")
            {
                pnl_molecules.Controls.Clear();
                var molecules = MoleculeController.getAll();
                molecules = molecules.Where(m => m.real_name.Contains(tbox_search.Text) || m.generic_name.Contains(tbox_search.Text) || m.formula.Contains(tbox_search.Text));
                foreach (var m in molecules)
                {
                    pnl_molecules.Controls.Add(new uc_MoleculeModel
                    {
                        id = m.id,
                        generic_name = m.generic_name,
                        real_name = m.real_name,
                        formula = m.formula
                    });
                }
            }
            else
            {
                ReloadPanel();
            }
        }


    }
}
