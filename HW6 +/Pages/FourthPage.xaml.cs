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

namespace HW6__
{
    /// <summary>
    /// Interaction logic for FourthPage.xaml
    /// </summary>
    public partial class FourthPage : Page
    {
        public FourthPage()
        {
            InitializeComponent();
        }

        private void Right_answer(object sender, RoutedEventArgs e)
        {
            Right.Background = Brushes.Green;
            Wrong.IsEnabled= false;
        }

        private void Wrong_answer(object sender, RoutedEventArgs e)
        {
            Wrong.Background = Brushes.Red;
            Right.IsEnabled = false;
        }

        private void ToFifthPage(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Uri("./Pages/FifthPage.xaml", UriKind.Relative));

        }
    }
}
