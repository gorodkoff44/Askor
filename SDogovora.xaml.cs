﻿using System;
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
            try
            {
                DGridClient.ItemsSource = DbAskorEntities.GetContext().Strahov.ToList();
                Console.WriteLine("ToList");
            }
            catch
            {
                MessageBox.Show("Нет соединения с базой данных!");
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/ObStrPage.xaml", UriKind.Relative));
            NavigationService.Navigate(new EditPage((sender as Button).DataContext as Strahov));

        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            var StrahovForRemoving = DGridClient.SelectedItems.Cast<Strahov>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {StrahovForRemoving.Count()} элементов?", "Внимание",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DbAskorEntities.GetContext().Strahov.RemoveRange(StrahovForRemoving);
                    DbAskorEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridClient.ItemsSource = DbAskorEntities.GetContext().Strahov.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            DGridClient.ItemsSource = DbAskorEntities.GetContext().Strahov.ToList();
        }
    }
}
