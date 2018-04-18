using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.WinForms;
using System.Windows.Forms.Integration;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Media;
using WaterSystem_Model;
using LiveCharts;
using LiveCharts.Wpf;

namespace WaterSystem_v1.Helpers
{
    public static class ChartHelper
    {
        public static void FillChart(ElementHost chart, ChartModel chartModel)
        {
            try
            {
                switch (chartModel.ChartType)
                {
                    case ChartType.BarChart:
                        GetBarChart(chart, chartModel);
                        break;
                    case ChartType.PieChart:
                        GetPieChart(chart, chartModel);
                        break;
                    case ChartType.Gauge180:
                        GaugeVertical180(chart, chartModel);
                        break;
                    case ChartType.Gauge360:
                        break;
                    case ChartType.Gauge360Vertical:
                        Gauge360Vertical(chart, chartModel);
                        break;
                    case ChartType.GaugeHorizontal180:
                        break;
                    case ChartType.AngularGaugeChart:
                        GetAngularGaugeChart(chart, chartModel);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region GuageVertical180
        private static void GaugeVertical180(ElementHost chart, ChartModel chartModel)
        {
            var guageChart = chart as SolidGauge;
            guageChart.From = chartModel.Min;
            guageChart.To = chartModel.Max;
            guageChart.Value = chartModel.Value;
            guageChart.Base.LabelsVisibility = VisibilityMapper[chartModel.Visible];
            guageChart.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = GetGradientStops(chartModel.GradientStop)
            };
        }

        private static GradientStopCollection GetGradientStops(Dictionary<Color, double> gradients)
        {
            GradientStopCollection gradientsStops = new GradientStopCollection();
            if (gradients != null)
            {
                foreach (var gradient in gradients)
                {
                    gradientsStops.Add(new GradientStop { Color = gradient.Key, Offset = gradient.Value });
                }
            }
            return gradientsStops;
        }
        #endregion

        #region Pie Chart
        private static void GetPieChart(ElementHost chart, ChartModel chartModel)
        {
            var pieChartSetting = chart as LiveCharts.WinForms.PieChart;
            pieChartSetting.Series = chartModel.PieSeriesCollection.ToSeriesCollection();
          
            // Default bottom
            pieChartSetting.LegendLocation = LegendLocation.Bottom;
            pieChartSetting.Font = new System.Drawing.Font("Verdana", 6);
        }

        private static SeriesCollection ToSeriesCollection(this List<PieSeriesConfig> pieSeriesConfig)
        {
            SeriesCollection seriesCollection = new LiveCharts.SeriesCollection();
            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            foreach (var pieSeries in pieSeriesConfig)
            {
                seriesCollection.Add(
                    new PieSeries
                    {
                        Title = pieSeries.Title,
                        Values = pieSeries.Values.ToChartValues(),
                        DataLabels = pieSeries.DataLabels,
                        LabelPoint = labelPoint,
                        PushOut = pieSeries.PushOut
                    });
            }
            return seriesCollection;
        }
       
        #endregion

        #region AngularGaugeChart
        private static void GetAngularGaugeChart(ElementHost chart, ChartModel chartModel)
        {
            var angularChartSetting = chart as LiveCharts.WinForms.AngularGauge;
            angularChartSetting.Value = chartModel.Value;
            angularChartSetting.FromValue = chartModel.Min;
            angularChartSetting.ToValue = chartModel.Max;

            // Defualt Setting
            angularChartSetting.TicksForeground = Brushes.White;
            angularChartSetting.Base.Foreground = Brushes.White;
            angularChartSetting.Base.FontWeight = FontWeights.Medium;
            angularChartSetting.Base.FontSize = 12;
            angularChartSetting.SectionsInnerRadius = 0.5;
            angularChartSetting.Sections = chartModel.AngularSections.ToAngularSection();
        }

        private static List<AngularSection> ToAngularSection(this List<AngularSectionConfig> sections)
        {
            List<AngularSection> angularSections = new List<AngularSection>();
            foreach (var section in sections)
            {
                angularSections.Add(new AngularSection
                {
                    FromValue = section.Min,
                    ToValue = section.Max,
                    Fill = new SolidColorBrush(section.Color)
                });
            }
            return angularSections;
        }
        #endregion

        #region Bar Chart
        private static void GetBarChart(ElementHost chart, ChartModel chartModel)
        {
            var cartesianChart = chart as LiveCharts.WinForms.CartesianChart;
            //adding series will update and animate the chart automatically
            cartesianChart.Series = chartModel.ColumnSeriesCollection.ToSeriesCollection();

            cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = chartModel.AxisX.Title,
                Labels = chartModel.AxisX.Values
            });

            cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = chartModel.AxisY.Title,
                LabelFormatter = value => value.ToString("N")
            });
        }

        private static SeriesCollection ToSeriesCollection(this List<ColumnSeriesConfig> columnSeriesConfig)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var columnSeries in columnSeriesConfig)
            {
                series.Add(
                    new ColumnSeries
                    {
                        Title = columnSeries.Title,
                        Values = columnSeries.Values.ToChartValues()
                    });
            }
            return series;
        }
        #endregion

        private static void Gauge360Vertical(ElementHost chart, ChartModel chartModel)
        {
            var guageChart = chart as SolidGauge;
            guageChart.Uses360Mode = true;
            guageChart.From = chartModel.Min;
            guageChart.To = chartModel.Max;
            guageChart.Value = chartModel.Value;
            guageChart.Base.GaugeRenderTransform = new TransformGroup
            {
                Children = new TransformCollection
                {
                    new RotateTransform(90),
                    new ScaleTransform {ScaleX = -1}
                }
            };
        }

        #region Common
        private static ChartValues<double> ToChartValues(this List<double> inputValues)
        {
            ChartValues<double> values = new ChartValues<double>();
            foreach (var inputValue in inputValues)
            {
                values.Add(inputValue);
            }
            return values;
        }

        public static Dictionary<VisibilityOption, Visibility> VisibilityMapper = new Dictionary<VisibilityOption, Visibility>
        {
            { VisibilityOption.Visible, Visibility.Visible },
            {VisibilityOption.Collapsed, Visibility.Collapsed },
            {VisibilityOption.Hidden, Visibility.Hidden }
        };
        #endregion
    }
}
