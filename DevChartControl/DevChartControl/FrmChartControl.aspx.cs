using System;
using System.Web.UI.DataVisualization.Charting;

namespace DevChartControl
{
    public partial class FrmChartControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayChart();
        }

        private void DisplayChart()
        {
            ctlChart2.Series[0].ChartType = SeriesChartType.Column;

            ctlChart2.Series[0].Points.AddXY("국어", 90);
            ctlChart2.Series[0].Points.AddXY("영어", 100);
            ctlChart2.Series[0].Points.AddXY("수학", 95);
        }
    }
}
