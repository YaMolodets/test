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

namespace Lira
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Event> events = new List<Event>();
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = events;
            dataGrid.UpdateLayout();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddEventWindow wind = new Windows.AddEventWindow();
            wind.Show();
            this.Close();
        }
    }
}
