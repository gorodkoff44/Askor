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
            DGridClient.ItemsSource = DbAskorEntities.GetContext().DBClient.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var AskorForRemoving = DGridClient.SelectedItems.Cast<DBClient>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {AskorForRemoving.Count()} элементов?", "Внимание!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DbAskorEntities.GetContext().DBClient.RemoveRange(AskorForRemoving);
                    DbAskorEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    DGridClient.ItemsSource = DbAskorEntities.GetContext().DBClient.ToList();
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

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            //var AskorForInfo = DGridClient.SelectedItems.Cast<DBClient>().ToList();
            //InfoClient infoClient = new InfoClient(AskorForInfo);
            //infoClient.Show();
        }
    }
}

