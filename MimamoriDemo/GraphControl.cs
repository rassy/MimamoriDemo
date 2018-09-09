using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using jp.co.brycen.MimamoriDemo.Properties;

namespace jp.co.brycen.MimamoriDemo
{
    public partial class GraphControl : UserControl
    {
        public GraphControl()
        {
            InitializeComponent();

            RefreshChart();

            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            try
            {
                //timer.Interval = int.Parse(Settings.Default["GraphInterval"].ToString());
                timer.Interval = 3000;
            }
            catch
            {
                timer.Interval = 1000;
            }
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RefreshChart();
        }
        private void RefreshChart()
        {
            CreateChart(chart1, "端末１", pictureBox1, lblTemp1, lblHumid1, lblTimeStamp1);
            CreateChart(chart2, "端末２", pictureBox2, lblTemp2, lblHumid2, lblTimeStamp2);
            CreateChart(chart3, "端末３", pictureBox3, lblTemp3, lblHumid3, lblTimeStamp3);
        }
        private void CreateChart(Chart chart, string strIdName, PictureBox pictureBox, Label lblTemp, Label lblHumid, Label lblTimeStamp)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Titles.Clear();

            // 温度
            var tempSeries = new Series();
            tempSeries.ChartType = SeriesChartType.Column;
            tempSeries.LegendText = "温度";
            tempSeries.XValueMember = "timestamp";
            tempSeries.YValueMembers = "temp";
            tempSeries.YAxisType = AxisType.Primary;

            // 湿度
            var humidSeries = new Series();
            humidSeries.ChartType = SeriesChartType.Line;
            humidSeries.LegendText = "湿度";
            humidSeries.BorderWidth = 2;
            humidSeries.MarkerStyle = MarkerStyle.Circle;
            humidSeries.XValueMember = "timestamp";
            humidSeries.YValueMembers = "humid";
            humidSeries.BorderColor = Color.Red;
            humidSeries.Color = Color.Red;
            humidSeries.YAxisType = AxisType.Secondary;

            ChartArea area = new ChartArea();
            area.AxisX.Title = "時間";
            area.AxisY.Title = "温度（℃）";
            area.AxisY2.Title = "湿度（％）";

            chart.ChartAreas.Add(area);
            chart.Series.Add(tempSeries);
            chart.Series.Add(humidSeries);

            chart.ChartAreas[0].AxisX.TextOrientation = TextOrientation.Horizontal;
            chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("ＭＳ ゴシック", 8);
            chart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("ＭＳ ゴシック", 8);
            chart.ChartAreas[0].AxisY2.LabelStyle.Font = new Font("ＭＳ ゴシック", 8);

            // データの読み込み
            var sourceDt = ImportCsvToDataTable(CreateDataTable(), Settings.Default["CsvFilePath"].ToString());

            var rows = sourceDt.Select(string.Format("id = '{0}'", strIdName));

            if (rows.Count() > 0)
            {
                switch(rows[rows.Count() - 1]["wbgt"].ToString())
                {
                    case "0":
                        pictureBox.Image = Resources.L00_注意;
                        break;
                    case "1":
                        pictureBox.Image = Resources.L01_警戒;
                        break;
                    case "2":
                        pictureBox.Image = Resources.L02_厳重警戒;
                        break;
                    case "3":
                        pictureBox.Image = Resources.L03_危険;
                        break;
                }

                lblTemp.Text = rows[rows.Count() - 1]["temp"].ToString();
                lblHumid.Text = rows[rows.Count() - 1]["humid"].ToString();
                DateTime datetime = DateTime.Parse(rows[rows.Count() - 1]["timestamp"].ToString());
                lblTimeStamp.Text = datetime.ToLongTimeString();

                chart.DataSource = rows.CopyToDataTable();
            }
            sourceDt.Dispose();
        }

        /// <summary>
        /// CSV読み込み用のDataTable作成
        /// </summary>
        /// <returns></returns>
        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("deviceid", typeof(string));
            dt.Columns.Add("temp", typeof(double));
            dt.Columns.Add("humid", typeof(double));
            dt.Columns.Add("wbgt", typeof(int));
            dt.Columns.Add("timestamp", typeof(DateTime));
            return dt;
        }

        /// <summary>
        /// CSVファイルをDataTableに読み込み
        /// </summary>
        /// <param name="dt"">DataTable</param>
        /// <param name="strFilePath">読み込むCSVのパス</param>
        /// <returns></returns>
        private DataTable ImportCsvToDataTable(DataTable dt,string strFilePath)
        {
            using (FileStream fs = new FileStream(strFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }
    }
}
