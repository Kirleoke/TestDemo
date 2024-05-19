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

namespace WpfApp1.Stranici
{
    /// <summary>
    /// Логика взаимодействия для Registraciya.xaml
    /// </summary>
    public partial class Registraciya : Page
    {
        public Registraciya()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (imya.Text == "" || familiya.Text == "" || login.Text == "" || parol.Password == "") {
                MessageBox.Show("Обязательные поля не заполены");
                return;
            }

            Klient klient = Singleton.DB.Klient.Add(new Klient()
            {
                Imya = imya.Text,
                Familiya = familiya.Text,
                Otchestvo = otchestvo.Text == "" ? null : otchestvo.Text,
                Login = login.Text,
                Parol = parol.Password,
                RoleID = 2
            }); ;
            Singleton.DB.SaveChanges();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.ramka.Navigate(new Login());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.ramka.Navigate(new Login());
        }
    }
}
