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
using Ionic.Zip;
//using System.IO.Compression;

namespace InstallerGSBrevet.Extract
{
    public partial class uc_Extract : UserControl
    {
        private form_Installer parent_form;
        public uc_Extract(form_Installer frm)
        {
            parent_form = frm;
            InitializeComponent();
        }

        private void uc_Extract_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(parent_form.path_installation)) // dossier d'installation
                Directory.Delete(path: parent_form.path_installation, recursive: true); // supprime tous les fichiers et dossier si il existe déjà

            Directory.CreateDirectory(parent_form.path_installation);
            parent_form.WriteToLog("Création du dossier qui contiendra GSBrevets");

            using (ZipFile zip = ZipFile.Read(parent_form.path_zip_file))
            {
                zip.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(zip_ExtractProgress);
                zip.ExtractAll(parent_form.path_installation, ExtractExistingFileAction.OverwriteSilently);

            }
            parent_form.WriteToLog("Extraction des fichiers téléchargés");


        }

        void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                pbar_download.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
                lbl_progress.Text = $"{pbar_download.Value} %";
                parent_form.WriteToLog($"Extraction des fichiers... {pbar_download.Value} %");
            }
            if (e.TotalBytesToTransfer >= 100)
                btn_next.Enabled = true;
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
