using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TalkToMePharmaDashBoard.Api;

namespace TalkToMePharmaDashBoard
{
    public partial class StatisticsForm : Form
    {
        public AdminUser User;
        Api.WebApi api = new Api.WebApi();
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("StatisticsForm" + User.FullName);
            LoadStatistics();
            
        }

        private void timerStatistics_Tick(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
           
            List<SearchStats> statistics = api.GetStats(User);

            dataGridViewStatisticsList.Rows.Clear();
            foreach (SearchStats search in statistics)
            {
                dataGridViewStatisticsList.Rows.Add(search.DrugName,search.Barcode,search.BarcodeID,search.UserID,search.DateOfCreate);
            }


            var drugsTopFive = from drugs in statistics
                               group drugs by drugs.DrugName into drugsGroup 
                                select new
                                {
                                    ID = drugsGroup.Key,
                                    Count = drugsGroup.Count().ToString(),
                                };

            drugsTopFive = drugsTopFive.OrderByDescending(o => o.Count).ToList();
            string drugsTopFiveString = String.Join(",", drugsTopFive);




            var usersTopFive = from drugs in statistics
                               group drugs by drugs.UserID into usersGroup
                               select new 
                               {
                                   ID = usersGroup.Key,
                                   Count = usersGroup.Count().ToString(),
                               };

            usersTopFive = usersTopFive.OrderByDescending(o => o.Count).ToList();
            string usersTopFiveString = String.Join(",", usersTopFive);
            //MessageBox.Show(usersTopFiveString);







            DrawChart(drugsTopFiveString, chartTopDrugs, "EN ÇOK DİNLENEN İLK 5 İLAÇ");
            DrawChart(usersTopFiveString, chartTopUsers, "UYGULAMAYI EN AKTİF KULLANAN İLK 5 KULLANICI");


            labelLastUpdate.Text = "Son güncelleme :" + DateTime.Now.ToLongTimeString() + "   " + DateTime.Now.ToLongDateString();
        }


      
        private void DrawChart(string TopFive, Chart chart, String Title)
        {
            TopFive = TopFive.Replace("},{", "?").Replace("{", "").Replace("}",""); ;
            var tops = TopFive.Split('?');
           





            chart.Series[0].ChartType = SeriesChartType.Pie;
            chart.Legends[0].Enabled = true;
            chart.ChartAreas[0].Area3DStyle.Enable3D = true;



            //reset your chart series and legends
            chart.Series.Clear();
            chart.Legends.Clear();





            //Add a new Legend(if needed) and do some formating
            chart.Legends.Add("MyLegend");
            chart.Legends[0].LegendStyle = LegendStyle.Table;
            chart.Legends[0].Docking = Docking.Bottom;
            chart.Legends[0].Alignment = StringAlignment.Center;
            chart.Legends[0].Title = Title;
            chart.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            chart.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart.Series[seriesname].ChartType = SeriesChartType.Pie;


            int counter = 0;
            foreach (var top in tops)
            {
                if (counter < 5)
                {
                    string ID = top.Substring(0, top.LastIndexOf(','));
                    string Count = top.Replace(ID, "");

                    ID = ID.Replace("ID =", "").Trim();
                    Count = Count.Replace(", Count =", "").Trim();

                    string message=ID+" \n("+Count+" Adet Dinleme)";
                    while (message.Length < 200)
                        message = message + " ";
                  
                    chart.Series[seriesname].Points.AddXY(message, Convert.ToInt32(Count));
                    counter++;
                }
            }
         


            chart.Series[seriesname]["PieLabelStyle"] = "Disabled";
        }
    }
}
