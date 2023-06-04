using LiveCharts.Defaults;
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
    /// Interaction logic for PieChart.xaml
    /// </summary>
    public partial class PieChart : UserControl
    {
        public PieChart()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Food",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(721.07) },
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(120,75,60,145)),

                    DataLabels = false
                },
                new PieSeries
                {
                    Title = "Transport",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(68.19) },
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(120,27,208,245)),
                    DataLabels = false
                },
                new PieSeries
                {
                    Title = "Rent",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(898.57) },
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(120,252,111,139)),
                    DataLabels = false
                },
                new PieSeries
                {
                    Title = "Internet Purchases",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(81.46) },
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(120,103, 156, 235)),
                    DataLabels = false
                }
            };

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
    }    
}