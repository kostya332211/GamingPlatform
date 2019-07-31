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
using System.Threading;
using GamingPlatform.AllLogic;



namespace GamingPlatform.UserControlMainWindow
{
    /// <summary>
    /// Логика взаимодействия для ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : UserControl
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        public void GoToHome(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new StartMainMenu();
        }

        async private void buttonChange_Click(object sender, RoutedEventArgs e)
        {
            if (newPassword.Password != newPasswordRepeat.Password)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            else if (newPassword.Password == "") MessageBox.Show("Пароль не может быть пустым");
            else if (ActiveUser.UserPassword != oldPassword.Text)
            {
                MessageBox.Show("Неверный старый пароль");
            }
            else
            {
                UsersRepository ur = UsersRepository.Initialize();
                await Task.Run(() => { ur.ChangePassword(newPassword.Password); });
            }

        }
    }
}
