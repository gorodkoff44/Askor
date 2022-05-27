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
    /// Логика взаимодействия для SDogovora.xaml
    /// </summary>
    public partial class SDogovora : Page
    {
        public SDogovora()
        {
            InitializeComponent();
            DGridClient.ItemsSource = AskorEntities1.GetContext().Client.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var AskorForRemoving = DGridClient.SelectedItems.Cast<Client>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {AskorForRemoving.Count()} элементов?", "Внимание!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AskorEntities1.GetContext().Client.RemoveRange(AskorForRemoving);
                    AskorEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void TestAvto_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TestAvto.xaml", UriKind.Relative));
        }
    }
}

