using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGSBrevet.Views.Shared
{
    public partial class uc_MainMenu : UserControl
    {
        public uc_MainMenu()
        {
            InitializeComponent();
        }
        #region load UserControl inside a panel
        private static uc_MainMenu _instance;
        public static uc_MainMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainMenu();
                return _instance;
            }
        }
        #endregion

    }
}
