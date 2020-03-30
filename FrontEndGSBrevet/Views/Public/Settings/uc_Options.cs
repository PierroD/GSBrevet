using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGSBrevet.Views.Public.Settings
{
    public partial class uc_Options : UserControl
    {
        public uc_Options()
        {
            InitializeComponent();
        }
        #region load UserControl inside a panel
        private static uc_Options _instance;
        public static uc_Options Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_Options();
                return _instance;
            }
        }
        #endregion
    }
}
