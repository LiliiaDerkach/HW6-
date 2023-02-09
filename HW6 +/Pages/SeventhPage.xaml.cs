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

namespace HW6__.Pages
{
    /// <summary>
    /// Interaction logic for SeventhPage.xaml
    /// </summary>
    public partial class SeventhPage : Page
    {
        public SeventhPage()
        {
            InitializeComponent();
            if (App.Counter <= 2)
            {
                Result.Text = "Ваш результат: " + App.Counter + " б." + "\nВи не здали тест";
                CryHomer.Visibility = Visibility.Visible;
                HappyAnimals.Visibility = Visibility.Hidden;
            }
            else if (App.Counter > 2)
            {
                Result.Text = "Ваш результат: " + App.Counter + " б." + "\nВи успішно здали тест \nВІТАЄМО!";
                CryHomer.Visibility = Visibility.Hidden;
                HappyAnimals.Visibility= Visibility.Visible;
            }
        }
        
    }
}
