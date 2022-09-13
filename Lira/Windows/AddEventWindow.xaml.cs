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
using System.Windows.Shapes;

namespace Lira.Windows
{
    /// <summary>
    /// Interaction logic for AddEvent.xaml
    /// </summary>
    public partial class AddEventWindow : Window
    {
        public AddEventWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Event @event = new Event();
                @event.TypeOfInstitution = institutionEv.Text;
                @event.TypeOfIvent = typeEv.Text;
                @event.TimeEvent = DateTime.Parse(dateEv.Text);
                @event.CountTicket = int.Parse(countTickEv.Text);
                @event.PriceTicket = int.Parse(priceTickEv.Text);
                MainWindow.events.Add(@event);
            }
            catch { }
        }
    }
}
