using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace HW6__.Pages
{
    /// <summary>
    /// Interaction logic for SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void ToThirdPage(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Uri("./Pages/ThirdPage.xaml", UriKind.Relative));
        }

        private void Right_answer(object sender, RoutedEventArgs e)
        {
            Right.Background = Brushes.Green;
            Wrong.IsEnabled = false;
            App.Counter = App.Counter + 1;
        }

        private void Wrong_answer(object sender, RoutedEventArgs e)
        {
            Wrong.Background = Brushes.Red;
            Right.IsEnabled = false;
        }
    }
}
