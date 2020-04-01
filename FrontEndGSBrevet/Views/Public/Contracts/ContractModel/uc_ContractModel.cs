using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGSBrevet.Views.Public.Contracts.ContractModel
{
    public partial class uc_ContractModel : UserControl
    {
        public uc_ContractModel()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string company { get; set; }
        public string patent { get; set; }
        public DateTime create_date{ get; set; }
        public int duration { get; set; }
        public double price { get; set; }

        private void uc_ContractModel_Load(object sender, EventArgs e)
        {
            lbl_id.Text = id.ToString();
            lbl_company.Text = company;
            lbl_patent.Text = patent;
            lbl_create_date.Text = create_date.ToString();
            lbl_duration.Text = duration.ToString() + "an(s)";
            lbl_price.Text = price.ToString().Replace('.',',') + "€";
        }
    }
}
