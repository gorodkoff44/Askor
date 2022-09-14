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
using System.Windows.Shapes;

namespace Страховая
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public MainWindow mainWindow;
        //private Login _currentLogin = new Login();
        public Login()
        {
            InitializeComponent();
            ln.MaxLength = 9;
            pv.MaxLength = 9;
        }

        private void Login_Click(object sender, RoutedEventArgs e) //заглушка для запуска без бд
        {
            try
            {
                if (ln.Text.Length > 0) // проверяем введён ли логин     
                {
                    if (pv.Password.Length > 0) // проверяем введён ли пароль         
                    {             // ищем в базе данных пользователя с такими данными         
                        //DbAskorEntities Login = mainWindow.Select("SELECT * FROM [dbo].[Login] WHERE [login1] = '" + ln.Text + "' AND [Password] = '" + pv.Password + "'");
                        //if (Login.Rows.Count > 0) // если такая запись существует       
                        //{
                        //    MessageBox.Show("Пользователь авторизовался"); // говорим, что авторизовался         
                        //}
                        //else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                    }
                    else MessageBox.Show("Введите пароль"); // выводим ошибку    
                }
                else MessageBox.Show("Введите логин"); // выводим ошибку
            }
            catch
            {
                MessageBox.Show("Нет соединения с базой данных!");
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
            }
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
