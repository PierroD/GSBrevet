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

namespace FrontEndGSBrevet.Views.Public.Patents.CreateUpdate
{
    public partial class uc_CreateUpdatePatent : UserControl
    {
        public uc_CreateUpdatePatent()
        {
            InitializeComponent();
        }

        #region structure
        public int id { get; set; }
        public int molecule_id { get; set; }
        public int company_id { get; set; }
        public string country { get; set; }
        public string number { get; set; }
        public DateTime deposit_date { get; set; }
        public int duration { get; set; }
        #endregion

        #region load UserControl inside a panel
        private static uc_CreateUpdatePatent _instance;
        public static uc_CreateUpdatePatent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_CreateUpdatePatent();
                return _instance;
            }
        }

        #endregion


        #region comboboxes molecules & companies
        private void cbox_molecules_Click(object sender, EventArgs e)
        {
            cbox_molecules.Items.Clear();
            var molecules = MoleculeController.getAll();
            foreach (var molecule in molecules)
            {
                cbox_molecules.Items.Add(molecule.real_name);
            }
        }

        private void cbox_companies_Click(object sender, EventArgs e)
        {
            cbox_companies.Items.Clear();
            var companies = CompanyController.getAll();
            foreach (var company in companies)
            {
                cbox_companies.Items.Add(company.name);
            }
        }
        #endregion



        private void btn_back_to_AllPatents_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btn_send_to_database_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                PatentController.UpdatePatent(id, MoleculeController.getByName(cbox_molecules.Text), CompanyController.getByName(cbox_companies.Text), tbox_country.Text, tbox_number.Text, dtime_deposit_date.Value, (int)nbox_duration.Value);
                MessageBox.Show("Le brevet a été correctement mise à jour dans la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PatentController.AddPatent(MoleculeController.getByName(cbox_molecules.Text), CompanyController.getByName(cbox_companies.Text), tbox_country.Text, tbox_number.Text, dtime_deposit_date.Value, (int)nbox_duration.Value);
                MessageBox.Show("Le brevet a été correctement ajoutée à la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            uc_MainPatent.Instance.ReloadPanel();
            this.SendToBack();

        }

        private void uc_CreateUpdatePatent_Load(object sender, EventArgs e)
        {
            if (molecule_id != 0)
            {
                cbox_molecules.Items.Add(MoleculeController.getById(molecule_id).real_name);
                cbox_molecules.SelectedIndex = 0;
            }
            if (company_id != 0)
            {
                cbox_companies.Items.Add(CompanyController.getById(company_id).name);
                cbox_companies.SelectedIndex = 0;
            }
            if (country != null)
                tbox_country.Text = country;
            if (number != null)
                tbox_number.Text = number.Substring(3);
            if (deposit_date >= dtime_deposit_date.MinDate)
                dtime_deposit_date.Value = deposit_date;
            if (duration != 0)
                nbox_duration.Value = duration;
        }

        #region textbox enter / leave
        private void tbox_country_Enter(object sender, EventArgs e)
        {
            if (tbox_country.Text == "Renseignez un nom de pays")
                tbox_country.Text = "";

            tbox_country.ForeColor = Color.Black;
        }

        private void tbox_country_Leave(object sender, EventArgs e)
        {
            if (tbox_country.Text == String.Empty)
                tbox_country.Text = "Renseignez un nom de pays";

            tbox_country.ForeColor = Color.Gray;
        }

        private void tbox_number_Enter(object sender, EventArgs e)
        {
            if (tbox_number.Text == "Renseignez numéro de brevet")
                tbox_number.Text = "";

            tbox_number.ForeColor = Color.Black;
        }

        private void tbox_number_Leave(object sender, EventArgs e)
        {
            if (tbox_number.Text == String.Empty)
                tbox_number.Text = "Renseignez numéro de brevet";

            tbox_number.ForeColor = Color.Gray;
        }
        #endregion


    }
}
