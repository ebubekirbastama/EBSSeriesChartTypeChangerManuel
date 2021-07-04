using System;
using System.Windows.Forms;

namespace EBSSeriesChartTypeChangerManuel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] chartyp = {
        "Point",
        "FastPoint",
        "Bubble",
        "Line",
        "Spline",
        "StepLine",
        "FastLine",
        "Bar",
        "StackedBar",
        "StackedBar100",
        "Column",
        "StackedColumn",
        "StackedColumn100",
        "Area",
        "SplineArea",
        "StackedArea",
        "StackedArea100",
        "Pie",
        "Doughnut",
        "Stock",
        "Candlestick",
        "Range",
        "SplineRange",
        "RangeBar",
        "RangeColumn",
        "Radar",
        "Polar",
        "ErrorBar",
        "BoxPlot",
        "Renko",
        "ThreeLineBreak",
        "Kagi",
        "PointAndFigure",
        "Funnel",
        "Pyramid"
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in chartyp)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Point":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                case "FastPoint":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                    break;
                case "Bubble":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
                    break;
                case "Line":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    break;
                case "Spline":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    break;
                case "StepLine":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
                    break;
                case "FastLine":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                    break;
                case "Bar":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    break;
                case "StackedBar":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
                    break;
                case "StackedBar100":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
                    break;
                case "Column":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case "StackedColumn":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                    break;
                case "StackedColumn100":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
                    break;
                case "Area":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    break;
                case "SplineArea":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                    break;
                case "StackedArea":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
                    break;
                case "StackedArea100":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
                    break;
                case "Pie":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    break;
                case "Doughnut":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    break;
                case "Stock":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
                    break;
                case "Candlestick":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
                    break;
                case "Range":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
                    break;
                case "SplineRange":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
                    break;
                case "RangeBar":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
                    break;
                case "RangeColumn":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
                    break;
                case "Radar":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
                    break;
                case "Polar":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
                    break;
                case "ErrorBar":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
                    break;
                case "BoxPlot":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
                    break;
                case "Renko":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
                    break;
                case "ThreeLineBreak":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak;
                    break;
                case "Kagi":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Kagi;
                    break;
                case "PointAndFigure":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.PointAndFigure;
                    break;
                case "Funnel":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
                    break;
                case "Pyramid":
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
                    break;
                default:
                    break;
            }
        }
    }
}
