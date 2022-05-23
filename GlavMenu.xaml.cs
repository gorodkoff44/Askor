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
    /// Логика взаимодействия для GlavMenu.xaml
    /// </summary>
    public partial class GlavMenu : Page
    {
        private readonly DispatcherTimer timer = new DispatcherTimer();
        public static DateTime Today { get; }
        public GlavMenu()
        {
            InitializeComponent();
            //время
            timer.Interval = TimeSpan.FromSeconds(1);

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

    }
}
