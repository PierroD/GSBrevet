using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using BackEndGSBrevet.Controller;
using FrontEndGSBrevet.Utils;
using FrontEndGSBrevet.Views.Shared;

namespace FrontEndGSBrevet.Views.Public.Analytics
{
    public partial class uc_MainAnalytic : UserControl
    {
        public uc_MainAnalytic()
        {
            InitializeComponent();
        }

        private void uc_MainAnalytic_Load(object sender, EventArgs e)
        {
            LoadAnalytic();
        }

        private void LoadAnalytic()
        {

            cartesianChart_MoneyByTime.Series.Clear();
            cartesianChart_MoneyByTime.AxisX.Clear();
            cartesianChart_MoneyByTime.AxisY.Clear();
            pieChart_ContractsByCompany.Series.Clear();
            pieChart_UtilitiesByMolecule.Series.Clear();

            #region CartesianChart
            cartesianChart_MoneyByTime.AxisX.Add(new Axis
            {
                Title = "Mois",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }

            });
            cartesianChart_MoneyByTime.AxisY.Add(new Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C2")
            });
            SeriesCollection series = new SeriesCollection();
            var request = ContractController.getYears();
            for (int year = request.Item1; year <= request.Item2; year++)
            {
                List<double> values = new List<double>();
                for (int month = 0; month <= 12; month++)
                {
                    values.Add(ContractController.getPriceFromMonth(year, month));
                }
                series.Add(new LineSeries() { Title = year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart_MoneyByTime.Series = series;
            cartesianChart_MoneyByTime.LegendLocation = LegendLocation.Right;
            #endregion

            #region pieChart
            var companies = CompanyController.getAll();
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            foreach (var company in companies)
            {
                var contracts = ContractController.getByCompany(company.id);
                pieChart_ContractsByCompany.Series.Add(new PieSeries
                {
                    Title = company.name,
                    Values = new ChartValues<double> { contracts.Count() },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }
            pieChart_ContractsByCompany.LegendLocation = LegendLocation.Bottom;
            var molecules = MoleculeController.getAll();
            foreach (var molecule in molecules)
            {
                var utilities = UtilityController.getByMolecule(molecule.id);
                pieChart_UtilitiesByMolecule.Series.Add(new PieSeries
                {
                    Title = molecule.real_name,
                    Values = new ChartValues<double> { utilities.Count() },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }
            pieChart_UtilitiesByMolecule.LegendLocation = LegendLocation.Bottom;
            #endregion

            // Load all chart
            cartesianChart_MoneyByTime.Hide();
            cartesianChart_MoneyByTime.Show();
            pieChart_ContractsByCompany.Hide();
            pieChart_ContractsByCompany.Show();
            pieChart_UtilitiesByMolecule.Hide();
            pieChart_UtilitiesByMolecule.Show();
        }

        private void btn_refreshData_Click(object sender, EventArgs e)
        {
            LoadAnalytic();
        }
    }
}
