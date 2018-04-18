using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WaterSystem_Model
{
    public class ChartModel
    {
        public double Min { get; set; }
        public double Max { get; set; }
        public double Value { get; set; }
        public VisibilityOption Visible { get; set; }
        public ChartType ChartType { get; set; }
        public List<ColumnSeriesConfig> ColumnSeriesCollection { get; set; }
        public List<PieSeriesConfig> PieSeriesCollection { get; set; }
        public Dictionary<Color, double> GradientStop { get; set; }
        public List<AngularSectionConfig> AngularSections { get; set; }
        public Axis AxisX { get; set; }
        public Axis AxisY { get; set; }
    }

    public class AngularSectionConfig
    {
        public double Min { get; set; }
        public double Max { get; set; }
        public Color Color { get; set; }
    }

    public class PieSeriesConfig
    {
        public string Title { get; set; }
        public List<double> Values { get; set; }
        public bool DataLabels { get; set; }
        public int PushOut { get; set; }
    }

    public class ColumnSeriesConfig
    {
        public string Title { get; set; }
        public List<double> Values { get; set; }
    }

    public class Axis
    {
        public string Title { get; set; }
        public List<string> Values { get; set; }
    }

    public enum VisibilityOption:byte
    {
        Visible = 0,
        Hidden = 1,
        Collapsed = 2
    }

    public enum ChartType: byte
    {
        PieChart = 0,
        BarChart = 1,
        Gauge360 = 2,
        Gauge180 = 3,
        GaugeHorizontal180 = 4,
        Dought = 5,
        AngularGaugeChart = 6,
        Gauge360Vertical =7
    }
}
