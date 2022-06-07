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
    /// Логика взаимодействия для ZClient.xaml
    /// </summary>
    public partial class ZClient : Page
    {
        public int ps;
        private Client _currentClient = new Client();
        public ZClient()
        {
            InitializeComponent();
            DataContext = _currentClient;
        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentClient.F))
                errors.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_currentClient.I))
                errors.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_currentClient.O))
                errors.AppendLine("Укажите отчество");
            if (_currentClient.DR == null)
                errors.AppendLine("Введите дату рождения");
            if ((_currentClient.Passport < 1000000000)||(_currentClient.Passport > 9999999999))
                errors.AppendLine("Введите серию и номер паспорта");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            Temp temp = new Temp(Convert.ToInt32(pass.Text));
            AskorEntities1.GetContext().Client.Add(_currentClient);
            try
            {
                
                AskorEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                NavigationService.Navigate(new Uri("/ZAvto.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
