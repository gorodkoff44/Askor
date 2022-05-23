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
using System.Windows.Threading;

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
        private void Button_Click(object sender, RoutedEventArgs e) //Страница объекты страхования
        {
            Glm.Visibility = Visibility.Hidden; //Скрыть главное меню (фон)
            But.Visibility = Visibility.Hidden; //Скрыть кнопки главного меню
            ObStrp.Visibility = Visibility.Visible; //Открыть страницу объекты страхования
            Vix2.Visibility = Visibility.Visible; //Показать кнопку выхода
            Dogovora.Visibility = Visibility.Hidden;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e) //Тоже самое только в обратную сторону (Кнопка выход)
        {
            Glm.Visibility = Visibility.Visible;
            But.Visibility = Visibility.Visible;
            ObStrp.Visibility = Visibility.Hidden;
            Vix2.Visibility = Visibility.Hidden;
            Dogovora.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Договора
        {
            Glm.Visibility = Visibility.Hidden;
            But.Visibility = Visibility.Hidden;
            ObStrp.Visibility = Visibility.Hidden;
            Vix2.Visibility = Visibility.Visible;
            Dogovora.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //Выход
        {
            Close();
        }
    }
}
