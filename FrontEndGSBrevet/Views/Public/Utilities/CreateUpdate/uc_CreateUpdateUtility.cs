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

namespace FrontEndGSBrevet.Views.Public.Utilities.CreateUpdate
{
    public partial class uc_CreateUpdateUtility : UserControl
    {
        public uc_CreateUpdateUtility()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_CreateUpdateUtility _instance;
        public static uc_CreateUpdateUtility Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_CreateUpdateUtility();
                return _instance;
            }
        }

        #endregion

        #region structure
        public int id { get; set; }
        public int molecule_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        #endregion

        #region comboboxes
        private void cbox_molecules_Click(object sender, EventArgs e)
        {
            cbox_molecules.Items.Clear();
            var molecules = MoleculeController.getAll();
            foreach (var molecule in molecules)
            {
                cbox_molecules.Items.Add(molecule.real_name);
            }
        }
        #endregion

        private void uc_CreateUpdateUtility_Load(object sender, EventArgs e)
        {
            if(molecule_id != 0)
            {
                cbox_molecules.Items.Add(MoleculeController.getById(molecule_id).real_name);
                cbox_molecules.SelectedIndex = 0;
            }
            if (name != null)
                tbox_name.Text = name;
            if (description != null)
                tbox_description.Text = description;
        }

        private void btn_back_to_AllPatents_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        #region textboxes enter / leave
        private void tbox_name_Enter(object sender, EventArgs e)
        {
            if (tbox_name.Text == "Renseignez un nom d'utilitée")
                tbox_name.Text = "";

            tbox_name.ForeColor = Color.Black;
        }

        private void tbox_name_Leave(object sender, EventArgs e)
        {
            if (tbox_name.Text == String.Empty)
                tbox_name.Text = "Renseignez un nom d'utilitée";

            tbox_name.ForeColor = Color.Gray;
        }

        private void tbox_description_Enter(object sender, EventArgs e)
        {
            if (tbox_description.Text == "Renseignez une description")
                tbox_description.Text = "";

            tbox_description.ForeColor = Color.Black;

        }

        private void tbox_description_Leave(object sender, EventArgs e)
        {
            if (tbox_description.Text == String.Empty)
                tbox_description.Text = "Renseignez une description";

            tbox_description.ForeColor = Color.Gray;
        }
        #endregion

        private void btn_send_to_database_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                UtilityController.UpdateUtility(id, MoleculeController.getByName(cbox_molecules.Text), tbox_name.Text, tbox_description.Text);
                MessageBox.Show("L'utilité a été correctement mise à jour dans la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UtilityController.AddUtility(MoleculeController.getByName(cbox_molecules.Text), tbox_name.Text, tbox_description.Text);
                MessageBox.Show("L'utilité a été correctement ajoutée à la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            uc_MainUtility.Instance.ReloadPanel();
            this.SendToBack();


        }
    }
}
