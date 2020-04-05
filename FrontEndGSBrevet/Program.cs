using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//pour la réqlisation du graphisme
using FrontEndGSBrevet.Views.Public;

namespace FrontEndGSBrevet
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new form_Login());
            Application.Run(new form_Public());
        }
    }
}
