using System;
using System.Windows;
using System.Windows.Controls;

namespace HW6__.Pages
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class WelcomeCustom : Page
    {
        public WelcomeCustom()
        {
            InitializeComponent();
        }
        
        private void GoToSecondPage(object sender, RoutedEventArgs e)
        {
            //App.MainFrame.GoBack();
        }

        private void ToSecondPage(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Uri("./Pages/SecondPage.xaml", UriKind.Relative));
        }
    }
}
