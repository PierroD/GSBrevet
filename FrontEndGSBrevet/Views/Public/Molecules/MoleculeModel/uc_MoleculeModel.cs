using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
