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

namespace Страховая
{
    /// <summary>
    /// Логика взаимодействия для object_str.xaml
    /// </summary>
    public partial class object_str : Window
    {
        public object_str()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Zhil.Visibility == Visibility.Collapsed)
            {
                Zhil.Visibility = Visibility.Visible;
                SLife.Visibility = Visibility.Visible;
                return;
            }
            Zhil.Visibility = Visibility.Collapsed;
            SLife.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Auto.Visibility == Visibility.Collapsed)
            {
                Auto.Visibility = Visibility.Visible;
                SLife.Visibility = Visibility.Visible;
                return;
            }
            Auto.Visibility = Visibility.Collapsed;
            SLife.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Auto.Visibility == Visibility.Collapsed)
            {
                Auto.Visibility = Visibility.Visible;
                Zhil.Visibility = Visibility.Visible;
                return;
            }
            Auto.Visibility = Visibility.Collapsed;
            Zhil.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();

        }
    }
}