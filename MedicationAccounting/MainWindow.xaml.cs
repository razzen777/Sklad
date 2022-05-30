using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Services;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedicationAccounting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text.Trim();
            var password = Password.Text.Trim();

            if(login == String.Empty || password == String.Empty)
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            if(Authorisation.Login(login, password))
            {
                MessageBox.Show("Успешная авторизация");
                return;
            }
            MessageBox.Show("Неправильный логин или пароль");
        }
    }
}
