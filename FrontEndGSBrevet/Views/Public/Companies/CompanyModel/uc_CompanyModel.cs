using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGSBrevet.Views.Public.Companies.CompanyModel
{
    public partial class uc_CompanyModel : UserControl
    {
        public uc_CompanyModel()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }

        private void uc_CompanyModel_Load(object sender, EventArgs e)
        {
            lbl_id.Text = id.ToString();
            lbl_name.Text = name;
            lbl_address.Text = address;
            lbl_city.Text = city;
            lbl_zip_code.Text = zip_code;

        }
    }
}
