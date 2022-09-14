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
    /// Логика взаимодействия для ZAvto.xaml
    /// </summary>
    public partial class ZAvto : Page
    {
        private Strahov _currentStrahov = new Strahov();
        public ZAvto()
        {
            InitializeComponent();
            try
            {
                DataContext = _currentStrahov;
            }
            catch
            {
                MessageBox.Show("Нет соединения с базой данных!");
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentStrahov.F))
                errors.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_currentStrahov.I))
                errors.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_currentStrahov.O))
                errors.AppendLine("Укажите отчество");
            if (_currentStrahov.DR == null)
                errors.AppendLine("Введите дату рождения");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            DbAskorEntities.GetContext().Strahov.Add(_currentStrahov);
            try
            {
                DbAskorEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                NavigationService.Navigate(new Uri("/GlavMenu.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
