using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HW6__
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : Application
    {
        public static Frame MainFrame => ((MainWindow)Application.Current.MainWindow).MainFrame;
        public static int Counter = 0;
    }
}
