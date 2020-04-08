using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGSBrevet.Views.Admin.UserModel
{
    public partial class uc_UserModel : UserControl
    {
        public uc_UserModel()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public DateTime birth_date { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int role_id { get; set; }

    }
}
