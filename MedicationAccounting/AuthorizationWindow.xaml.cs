using Services;
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

namespace MedicationAccounting
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        MainWindow mainWindow = new MainWindow();
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        public void Login_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text.Trim();
            var password = Password.Text.Trim();

            if (login == String.Empty || password == String.Empty)
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            if (Authorisation.Login(login, password))
            {
                MessageBox.Show("Успешная авторизация");
                mainWindow.Show();
                Close();
                return;
            }
            MessageBox.Show("Неправильный логин или пароль");
        }
    }
}
