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

namespace Страховая
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object_str Object_Str = new object_str();
            Object_Str.ShowDialog();
            Object_Str.Owner = this;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dogovora Dogovora = new dogovora();
            Dogovora.ShowDialog();
            Dogovora.Owner = this;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StrWip strWip = new StrWip();
            strWip.ShowDialog();
            strWip.Owner = this;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
