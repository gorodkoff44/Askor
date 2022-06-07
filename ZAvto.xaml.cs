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
        private Avto _currentAvto = new Avto();
        //Фамилия, имя, отчество, марка авто, модель, год выпуска, мощность, VIN, ПТС, дата выдачи
        //string fa, im, ot,datr, gosn, cat, mark,mod,year,moshnost,vin,pts,datav,pasport;
        int pss;
        public ZAvto()
        {
            InitializeComponent();
            ZClient zClient = new ZClient();
            Console.WriteLine($"zClient.ps {zClient.ps}");
            DataContext = _currentAvto;
            
            pss = zClient.ps;
            Temp temp = new Temp(1);
            Pass.Text = temp.ToString();
            Console.WriteLine($"pss {pss}");
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            //if (string.IsNullOrWhiteSpace(_currentClient.F))
            //    errors.AppendLine("Укажите фамилию");
            //if (string.IsNullOrWhiteSpace(_currentClient.I))
            //    errors.AppendLine("Укажите имя");
            //if (string.IsNullOrWhiteSpace(_currentClient.O))
            //    errors.AppendLine("Укажите отчество");
            //if (string.IsNullOrWhiteSpace(_currentClient.F))
            //    errors.AppendLine("Укажите фамилию");
            //if (_currentClient.DR==null)
            //    errors.AppendLine("Введите дату рождения");
            //if (errors.Length >0)
            //{
            //    MessageBox.Show(errors.ToString());
            //    return;
            //}

                AskorEntities1.GetContext().Avto.Add(_currentAvto);
            try
            {
                AskorEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            //fa = fam.Text;
            //im = imya.Text;
            //ot = otch.Text;
            //datr = DR.Text;
            //gosn = gosnum.Text;
            //cat = Categ.Text;
            //mark = MarkaAvto.Text;
            //mod = model.Text;
            //year = gv.Text;
            //moshnost = ls.Text;
            //vin = vina.Text;
            //pts = snpts.Text;
            //datav = vidacha.Text;
            //pasport = Pass.Text;

            //if (fa==""||im==""||ot==""||datr == "" || gosn ==""||cat == "" ||mark == "" ||mod == "" ||year == "" ||moshnost == "" ||vin == "" ||pts == "" ||datav == "")
            //{
            //    MessageBox.Show("Введены не все данные" , "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //if (MessageBox.Show("Вы" + " " + fa + " " + im + " " + ot + ", а гос.номер вашего " + mark + " " + mod + ": " + gosn,
            //        "Save file",
            //        MessageBoxButton.YesNo,
            //        MessageBoxImage.Question) == MessageBoxResult.Yes)
            //{
            //    // Do something here
            //}
        }
    }
}
