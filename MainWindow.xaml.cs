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
        private readonly DispatcherTimer timer = new DispatcherTimer();
        public static DateTime Today { get; }
        public MainWindow()
        {
            InitializeComponent();
            //время
            timer.Interval = TimeSpan.FromSeconds(15);

            timer.Tick += Timer_Tick;
            timer.Start();
            DateTime thisDay = DateTime.Today;
            lblDate.Content = thisDay.ToString("D"); //Вывод даты
        }
        void Timer_Tick(object sender, EventArgs e) //время
        {
            string time = DateTime.Now.ToLongTimeString(); ; //хранит полное время
            string[] words = time.Split(new char[] { ':' }); //разделение данных часов минут и секунд
            lblTime.Content = words[0] + ":" + words[1]; //сборка часов и минут в 1 переменную и вывод
            //Console.WriteLine("Timer_Tick");
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Объекты страхования
        {
            object_str Object_Str = new object_str();
            Object_Str.ShowDialog();
            Object_Str.Owner = this;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Договора
        {
            dogovora Dogovora = new dogovora();
            Dogovora.ShowDialog();
            Dogovora.Owner = this;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //Страховые выплаты
        {
            StrWip strWip = new StrWip();
            strWip.ShowDialog();
            strWip.Owner = this;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //Выход
        {
            Close();
        }
    }
}
