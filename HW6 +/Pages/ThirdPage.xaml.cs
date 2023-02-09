using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

namespace HW6__
{
    /// <summary>
    /// Interaction logic for ThirdPage.xaml
    /// </summary>
    public partial class ThirdPage : Page
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        private void Wrong_answer1(object sender, RoutedEventArgs e)
        {
            Wrong1.Background = Brushes.Red;
            Wrong.IsEnabled = false;
            Right.IsEnabled = false;
        }

        private void Wrong_answer2(object sender, RoutedEventArgs e)
        {
            Wrong.Background = Brushes.Red;
            Wrong1.IsEnabled= false;
            Right.IsEnabled= false;
        }

        private void Right_answer(object sender, RoutedEventArgs e)
        {
            Right.Background = Brushes.Green;
            Wrong1.IsEnabled = false;
            Wrong.IsEnabled= false;
            App.Counter = App.Counter + 1;
        }

        private void ToFourthPage(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Uri("./Pages/FourthPage.xaml", UriKind.Relative));
        }
    }
}
