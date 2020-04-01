using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGSBrevet.Views.Public.Patents.PatentModel
{
    public partial class uc_PatentModel : UserControl
    {
        public uc_PatentModel()
        {
            InitializeComponent();
        }
        public string number { get; set; }
        public string molecule { get; set; }
        public string company { get; set; }
        public DateTime deposit_date { get; set; }
        public int duration { get; set; }
        public string country { get; set; }

        private void uc_PatentModel_Load(object sender, EventArgs e)
        {
            lbl_number.Text = number;
            lbl_molecule.Text = molecule;
            lbl_company.Text = company;
            lbl_deposit_date.Text = deposit_date.ToString();
            lbl_duration.Text = duration.ToString() + "an(s)";
            lbl_country.Text = country;
        }
    }
}
