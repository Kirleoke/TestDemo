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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Klient klient = Singleton.DB.Klient.FirstOrDefault(l =>
            l.Login == login.Text && l.Parol == parol.Password);
            if (klient == null)
            {
                MessageBox.Show("Не правильно введен логин или пароль");
            }
            else
            {
                MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                mainWindow.ramka.Navigate(new Zayavki());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.ramka.Navigate(new Registraciya());
        }
    }
}
