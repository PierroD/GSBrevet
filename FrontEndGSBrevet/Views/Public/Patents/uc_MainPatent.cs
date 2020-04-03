using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEndGSBrevet.Controller;
using FrontEndGSBrevet.Utils;
using FrontEndGSBrevet.Views.Public.Patents.PatentModel;
using FrontEndGSBrevet.Views.Public.Patents.CreateUpdate;

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

        private void uc_MainPatent_Load(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        public void ReloadPanel()
        {
            pnl_patents.Controls.Clear();
            var patents = PatentController.getAll(); // .OrderBy(t => t.id).Reverse()
            if (btn_orderby_depositDate.Checked)
               patents = patents.OrderBy(p => p.deposit_date); // trier par date de dépôt
            if (btn_orderby_molecule.Checked)
                patents = patents.OrderBy(p => p.molecule_id); // trier par molécule
            if (btn_orderby_company.Checked)
                patents = patents.OrderBy(p => p.company_id); // trier par entreprise
            foreach (var p in patents)
            {
                pnl_patents.Controls.Add(new uc_PatentModel
                {
                    id = p.id,
                    number = p.number,
                    molecule_id = p.molecule_id,
                    company_id = p.company_id,
                    deposit_date = p.deposit_date,
                    duration = p.duration,
                    country = p.country
                });
            }
        }

        private void btn_create_patent_Click(object sender, EventArgs e)
        {
            SwitchUC.Switch(form_Public.pnl_main, uc_CreateUpdatePatent.Instance);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        #region orderby
        private void btn_orderby_depositDate_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        private void btn_orderby_molecule_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }

        private void btn_orderby_company_Click(object sender, EventArgs e)
        {
            ReloadPanel();
        }
        #endregion

    }
}
