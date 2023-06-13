using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Controls;
using System.Windows.Media;

namespace Money_Manager.User_Controls
{
    /// <summary>
    /// Pie chart binding to appropriate data
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
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(120,133,138,227)),

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
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(120,255,99,146)),
                    DataLabels = false
                },
                new PieSeries
                {
                    Title = "Internet Purchases",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(81.46) },
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(120,255,228,94)),
                    DataLabels = false
                }
            };

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
    }    
}