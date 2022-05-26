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
            List<User> items = new List<User>();
            items.Add(new User() { Name = "Иванов Иван Иванович", Age = 42 });
            items.Add(new User() { Name = "Петров Петр Петрович", Age = 39 });
            items.Add(new User() { Name = "Смирнов Смир Смирович", Age = 13 });
            items.Add(new User() { Name = "Иванов Иван Иванович", Age = 42 });
            items.Add(new User() { Name = "Петров Петр Петрович", Age = 39 });
            items.Add(new User() { Name = "Смирнов Смир Смирович", Age = 13 });
            items.Add(new User() { Name = "Иванов Иван Иванович", Age = 42 });
            items.Add(new User() { Name = "Петров Петр Петрович", Age = 39 });
            items.Add(new User() { Name = "Смирнов Смир Смирович", Age = 13 });
            items.Add(new User() { Name = "Иванов Иван Иванович", Age = 42 });
            items.Add(new User() { Name = "Петров Петр Петрович", Age = 39 });
            items.Add(new User() { Name = "Смирнов Смир Смирович", Age = 13 });
            items.Add(new User() { Name = "Иванов Иван Иванович", Age = 42 });
            items.Add(new User() { Name = "Петров Петр Петрович", Age = 39 });
            items.Add(new User() { Name = "Смирнов Смир Смирович", Age = 13 });
            items.Add(new User() { Name = "Иванов Иван Иванович", Age = 42 });
            lvUsers.ItemsSource = items;
        }

        private void lvUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
