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

namespace Daniel.SECOND_QUARTERLY_ASSESSMENT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var url = "http://newsapi.org/v2/top-headlines?country=fr&category=business&apiKey=4a977cc9d4b44c8289ee00ad6c6b8040" +
                "country=fr&" +
                "category=business" +
                "apiKey=4a977cc9d4b44c8289ee00ad6c6b8040";

            var json = new WebClient().Downloadstring(url);

            Console.WriteLine(json);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
