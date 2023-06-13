using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Money_Manager.User_Controls
{
    /// <summary>
    /// Line chart (account balance) values 
    /// </summary>
    public partial class LineChart : UserControl
    {
        public LineChart()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Balance, €",
                    Values = new ChartValues<double> {1256.18, 1151.06, 1134.42, 1283.08, 1276.81, 698.26, 1347.65, 238.99}
                },
            };

            Labels = new[] { "Nov 22", "Dec 22", "Jan 23", "Feb 22", "Mar 23", "Apr 23", "May 23", "Jun 23" };
            YFormatter = value => value.ToString("C0");
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}