using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using WaterSystem_v1.Helpers;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using System.Globalization;

namespace WaterSystem_v1
{
    public partial class FrmDashboardCharts : Form
    {
        DashboardReciever _reciever = null;
        public FrmDashboardCharts()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            _reciever = new DashboardReciever();

            // Config Charts
            ExpensesChart();
            SalesRecoveryChart();
            SalesMonthlyChart();
            PendingSalesApprovalChart();
        }

        private void ExpensesChart()
        {
            try
            {
                var expensesLst = _reciever.GetExpensesReport();
                if (expensesLst != null)
                {
                    ChartModel chartModel = new ChartModel();
                    chartModel.PieSeriesCollection = new List<PieSeriesConfig>();
                    foreach (var expenses in expensesLst)
                    {
                        var pieSeries = new PieSeriesConfig();
                        pieSeries.Title = expenses.SubExpences_Name;
                        pieSeries.Values = new List<double>() { Convert.ToDouble(expenses.Amount) };
                        pieSeries.DataLabels = false;
                        chartModel.PieSeriesCollection.Add(pieSeries);
                    }
                    ChartHelper.FillChart(pieChartExpenses, chartModel);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SalesRecoveryChart()
        {
            try
            {
                var salesRecoveryLst = _reciever.GetSalesRecoveryReport();
                if (salesRecoveryLst != null)
                {
                    var salesRecovery = salesRecoveryLst.FirstOrDefault();
                    if (salesRecovery != null)
                    {
                        ChartModel chartModel = new ChartModel();
                        chartModel.Min = 0;
                        chartModel.Value = salesRecovery.PaidAmount;
                        chartModel.Max = salesRecovery.TotalAmount;
                        chartModel.ChartType = ChartType.Gauge180;
                        chartModel.GradientStop = new Dictionary<Color, double>()
                        {
                            { Colors.Yellow, 0 },
                            { Colors.Orange, 0.5 },
                            { Colors.Red, 1 }
                        };
                        ChartHelper.FillChart(solidGauge1, chartModel);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SalesMonthlyChart()
        {
            try
            {
                var salesReport = _reciever.GetSalesMonthWiseReport();
                if (salesReport != null)
                {
                    var chartValues = salesReport.Select(x => x.TotalSales).ToList();
                    var chartMonths = salesReport.Select(x => string.Format("{0}/{1}", CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(x.SalesMonth), x.SalesYear.ToString())).ToList();
                    ChartModel chartModel = new ChartModel();
                    chartModel.ChartType = ChartType.BarChart;
                    chartModel.ColumnSeriesCollection = new List<ColumnSeriesConfig>();
                    chartModel.ColumnSeriesCollection.Add(new ColumnSeriesConfig()
                    {
                        Title = "Sales",
                        Values = chartValues
                    });

                    chartModel.AxisX = new Axis
                    {
                        Title = "Month",
                        Values = chartMonths
                    };

                    chartModel.AxisY = new Axis
                    {
                         Title = "Month wise Sale",
                    };
                    ChartHelper.FillChart(cartesianChart1, chartModel);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void PendingSalesApprovalChart()
        {
            try
            {
                var salesApprovals = _reciever.GetSalesApprovalReport();
                if (salesApprovals != null)
                {
                    var approvals = salesApprovals.First();
                    ChartModel chartModel = new ChartModel();
                    chartModel.Min = 0;
                    chartModel.Max = approvals.TotalApproval;
                    chartModel.Value = approvals.PendingApproval;
                    chartModel.ChartType = ChartType.Gauge360Vertical;
                    ChartHelper.FillChart(solidGauge2, chartModel);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
