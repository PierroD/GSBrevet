using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGSBrevet.Views.Public.Contracts
{
    public partial class uc_MainContract : UserControl
    {
        public uc_MainContract()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_MainContract _instance;
        public static uc_MainContract Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainContract();
                return _instance;
            }
        }
        #endregion
    }
}
