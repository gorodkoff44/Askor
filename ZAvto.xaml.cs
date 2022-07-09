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
        private Strahov _currentClient = new Strahov();
        public ZAvto()
        {
            InitializeComponent();
            DataContext = _currentClient;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DbAskorNewEntities.GetContext().Strahov.Add(_currentClient);
                MessageBox.Show("Данные внесены");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
                return;
            }
        }
    }
}
