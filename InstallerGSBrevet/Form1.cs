using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using InstallerGSBrevet.Download;
using InstallerGSBrevet.Utils;

namespace InstallerGSBrevet
{
    public partial class form_Installer : Form
    {
        public form_Installer()
        {
            InitializeComponent();
        }

        private void form_Installer_Shown(object sender, EventArgs e)
        {
            SwitchUC.Switch(pnl_main, new uc_Download(this));
        }

        public string path_zip_file { get; set; }
        public string path_installation { get; set; }

        #region panel top
        bool mouseDown;
        int mouseX, mouseY, mouseinX, mouseinY;

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        #endregion

        public void WriteToLog(string text)
        {
            tbox_log.Text += text + Environment.NewLine;
        }

    }
}
