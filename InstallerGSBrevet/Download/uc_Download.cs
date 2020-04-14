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
using System.Net;
using InstallerGSBrevet.Utils;
using InstallerGSBrevet.Location;

namespace InstallerGSBrevet.Download
{
    public partial class uc_Download : UserControl
    {
        private form_Installer parent_form;
        public uc_Download(form_Installer frm)
        {
            parent_form = frm;
            InitializeComponent();
        }

        private void uc_Download_Load(object sender, EventArgs e)
        {
            string tempfolder = Path.GetTempPath() + "GSBrevets";
            if (!Directory.Exists(tempfolder))
                Directory.CreateDirectory(tempfolder);


            parent_form.path_zip_file = tempfolder + "\\" + Guid.NewGuid() + ".zip"; // on donne un nom unique au fichier comme ca si le téléchargement échoue on peut en relancer un sans problème
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(
                    // Param1 = lien du fichier à télécharger
                    new Uri("https://raw.githubusercontent.com/PierroD/PLogger/master/bin/Release/PLoggerv1.3.zip"),
                    // Param2 = lien de sauvegarde physique
                    parent_form.path_zip_file
                );
            }

        }
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbar_download.Value = e.ProgressPercentage;
            lbl_progress.Text = $"{e.ProgressPercentage}%";
            parent_form.WriteToLog($"Téléchargement de GSBrevets... {e.ProgressPercentage}%");
            if (e.ProgressPercentage >= 100)
            {
                btn_next.Enabled = true;
                parent_form.WriteToLog($"Téléchargement terminée");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(parent_form.pnl_main, new uc_Location(parent_form));
        }
    }
}
