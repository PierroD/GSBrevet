using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGSBrevet.Views.Admin.Role.RoleModel
{
    public partial class uc_RoleModel : UserControl
    {
        public uc_RoleModel()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string libelle { get; set; }
    }
}
