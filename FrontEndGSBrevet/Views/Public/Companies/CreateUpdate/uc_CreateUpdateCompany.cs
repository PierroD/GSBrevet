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

namespace FrontEndGSBrevet.Views.Public.Companies.CreateUpdate
{
    public partial class uc_CreateUpdateCompany : UserControl
    {
        public uc_CreateUpdateCompany()
        {
            InitializeComponent();
        }

        #region structure
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
        #endregion


        #region load UserControl inside a panel
        private static uc_CreateUpdateCompany _instance;
        public static uc_CreateUpdateCompany Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_CreateUpdateCompany();
                return _instance;
            }
        }

        #endregion


        #region textbox enter / leave

        private void tbox_name_Enter(object sender, EventArgs e)
        {
            if (tbox_name.Text == "Renseignez un nom d'entreprise")
                tbox_name.Text = "";

            tbox_name.ForeColor = Color.Black;

        }

        private void tbox_name_Leave(object sender, EventArgs e)
        {
            if (tbox_name.Text == String.Empty)
                tbox_name.Text = "Renseignez un nom d'entreprise";

            tbox_name.ForeColor = Color.Gray;
        }

        private void tbox_address_Enter(object sender, EventArgs e)
        {
            if (tbox_address.Text == "Renseignez une adresse")
                tbox_address.Text = "";

            tbox_address.ForeColor = Color.Black;
        }

        private void tbox_address_Leave(object sender, EventArgs e)
        {
            if (tbox_address.Text == String.Empty)
                tbox_address.Text = "Renseignez une adresse";

            tbox_address.ForeColor = Color.Gray;
        }

        private void tbox_city_Enter(object sender, EventArgs e)
        {
            if (tbox_city.Text == "Renseignez une ville")
                tbox_city.Text = "";

            tbox_city.ForeColor = Color.Black;
        }

        private void tbox_city_Leave(object sender, EventArgs e)
        {
            if (tbox_city.Text == String.Empty)
                tbox_city.Text = "Renseignez une ville";

            tbox_city.ForeColor = Color.Gray;

        }

        private void tbox_zip_code_Enter(object sender, EventArgs e)
        {
            if (tbox_zip_code.Text == "Renseignez un code postal")
                tbox_zip_code.Text = "";

            tbox_zip_code.ForeColor = Color.Black;
        }

        private void tbox_zip_code_Leave(object sender, EventArgs e)
        {
            if (tbox_zip_code.Text == String.Empty)
                tbox_zip_code.Text = "Renseignez un code postal";

            tbox_zip_code.ForeColor = Color.Gray;
        }
        #endregion

        #region create or update database
        private void uc_CreateUpdateCompany_Load(object sender, EventArgs e)
        {
            if (name != null)
                tbox_name.Text = name;
            if (address != null)
                tbox_address.Text = address;
            if (city != null)
                tbox_city.Text = city;
            if (zip_code != null)
                tbox_zip_code.Text = zip_code;
        }
        #endregion

        private void btn_back_to_AllCompanies_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btn_send_to_database_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                CompanyController.UpdateCompany(id, tbox_name.Text, tbox_address.Text, tbox_city.Text, tbox_zip_code.Text);
                MessageBox.Show("L'entreprise a été correctement mise à jour dans la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CompanyController.AddCompany(tbox_name.Text, tbox_address.Text, tbox_city.Text, tbox_zip_code.Text);
                MessageBox.Show("L'entreprise a été correctement ajoutée à la base de données", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            uc_MainCompany.Instance.ReloadPanel();
            this.SendToBack();
        }
    }
}
