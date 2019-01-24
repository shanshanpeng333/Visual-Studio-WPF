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

namespace Orion_Collection3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Display_Click(object sender, RoutedEventArgs e)
        {
            star1.Visibility = Visibility.Visible;
            star2.Visibility = Visibility.Visible;
            star3.Visibility = Visibility.Visible;
            star4.Visibility = Visibility.Visible;
            star5.Visibility = Visibility.Visible;
            star6.Visibility = Visibility.Visible;
            star7.Visibility = Visibility.Visible;
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            star1.Visibility = Visibility.Hidden;
            star2.Visibility = Visibility.Hidden;
            star3.Visibility = Visibility.Hidden;
            star4.Visibility = Visibility.Hidden;
            star5.Visibility = Visibility.Hidden;
            star6.Visibility = Visibility.Hidden;
            star7.Visibility = Visibility.Hidden;
        }
    }
}
