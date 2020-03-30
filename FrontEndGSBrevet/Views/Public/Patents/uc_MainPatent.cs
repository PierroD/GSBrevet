﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndGSBrevet.Views.Public.Patents
{
    public partial class uc_MainPatent : UserControl
    {
        public uc_MainPatent()
        {
            InitializeComponent();
        }

        #region load UserControl inside a panel
        private static uc_MainPatent _instance;
        public static uc_MainPatent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MainPatent();
                return _instance;
            }
        }
        #endregion
    }
}
