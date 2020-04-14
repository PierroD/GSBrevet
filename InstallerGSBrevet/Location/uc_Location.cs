using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using InstallerGSBrevet.Utils;
using InstallerGSBrevet.Extract;

namespace InstallerGSBrevet.Location
{
    public partial class uc_Location : UserControl
    {
        private form_Installer parent_form;
        public uc_Location(form_Installer frm)
        {
            parent_form = frm;
            InitializeComponent();
        }

        private void btn_folderbrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            dialog.Description = "Choisissez le dossier d'installation";
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lbl_installationPath.Text = dialog.SelectedPath;
                parent_form.path_installation = dialog.SelectedPath + "\\GSBrevets";
                parent_form.WriteToLog($"Dossier d'installation : {parent_form.path_installation}");
                btn_next.Enabled = true;
            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(parent_form.pnl_main, new uc_Extract(parent_form));
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
