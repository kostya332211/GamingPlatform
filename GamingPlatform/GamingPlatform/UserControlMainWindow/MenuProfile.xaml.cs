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
namespace GamingPlatform.UserControlMainWindow
{
    /// <summary>
    /// Логика взаимодействия для MenuProfile.xaml
    /// </summary>
    public partial class MenuProfile : UserControl
    {
        public MenuProfile()
        {

            InitializeComponent();
            this.nameField.Content = ActiveUser.UserName;
            this.loginField.Content = ActiveUser.UserLogin;
            this.dateField.Content = ActiveUser.DateRegistr;
        }
        public void GoToHome(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new StartMainMenu();
        }

        private void buttonChangePassword_MouseEnter(object sender, MouseEventArgs e)
        {
            labelChangePassword.Foreground = Brushes.Black;
        }

        private void buttonChangePassword_MouseLeave(object sender, MouseEventArgs e)
        {
            labelChangePassword.Foreground = Brushes.Gray;
        }

        private void buttonChangePassword_Click(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new ChangePassword();
        }
    }
}
