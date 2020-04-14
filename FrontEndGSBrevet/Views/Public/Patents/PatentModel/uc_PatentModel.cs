using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEndGSBrevet.Utils;
using BackEndGSBrevet.Controller;
using FrontEndGSBrevet.Views.Public.Patents.CreateUpdate;

namespace FrontEndGSBrevet.Views.Public.Patents.PatentModel
{
    public partial class uc_PatentModel : UserControl
    {
        public uc_PatentModel()
        {
            InitializeComponent();
        }

        #region structure
        public int id { get; set; }
        public string number { get; set; }
        public int molecule_id { get; set; }
        public int company_id { get; set; }
        public DateTime deposit_date { get; set; }
        public int duration { get; set; }
        public string country { get; set; }
        #endregion

        private void uc_PatentModel_Load(object sender, EventArgs e)
        {
            lbl_number.Text = number;
            lbl_molecule.Text = MoleculeController.getById(molecule_id).real_name;
            lbl_company.Text = CompanyController.getById(company_id).name;
            lbl_deposit_date.Text = deposit_date.ToString();
            lbl_duration.Text = duration.ToString() + "an(s)";
            lbl_country.Text = country;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, new uc_CreateUpdatePatent { id = id, molecule_id = molecule_id, company_id = company_id, country = country, number = number, deposit_date = deposit_date, duration = duration });
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (PatentController.PatentUsed(id))
            {
                PatentController.Delete(id);
                uc_MainPatent.Instance.ReloadPanel();
            }
            else
                MessageBox.Show("La molécule est utilisée par un brevet ou par un contrat", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
