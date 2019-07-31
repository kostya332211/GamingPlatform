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
using GamingPlatform.AllLogic;
using System.Threading;


namespace GamingPlatform.UserControlMainWindow
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void GoToSign(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mw.DataContext = new Sign();
        }

        async private void Registr_Click(object sender, RoutedEventArgs e)
        {
            ActiveUser.UserName = tbName.Text;
            ActiveUser.UserLogin = tbLogin.Text;
            ActiveUser.DateRegistr = DateTime.Now.ToString();
            ActiveUser.UserPassword = Password1.Password;
            if (ActiveUser.UserPassword != Password2.Password) MessageBox.Show("Пароли не совпадают");
            else if (ActiveUser.UserPassword == "") MessageBox.Show("Пароль не может быть пустым");
            else
            {
                UsersRepository ur = UsersRepository.Initialize();
                await Task.Run(() => { ur.Registration(); });
            }
        }
    }
}
