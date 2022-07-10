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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Strahov _currentStrahov = new Strahov();
        public EditPage(Strahov selectedStrahov)
        {
            InitializeComponent();
            DataContext = _currentStrahov;
            if (selectedStrahov != null)
                _currentStrahov = selectedStrahov;
            DataContext = _currentStrahov;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DbAskorEntities.GetContext().Strahov.Add(_currentStrahov);
                MessageBox.Show("Данные внесены");
                NavigationService.Navigate(new Uri("/SDogovora.xaml", UriKind.Relative));
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
                return;
            }
        }
    }
}
