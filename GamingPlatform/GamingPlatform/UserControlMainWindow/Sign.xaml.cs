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
    /// Логика взаимодействия для Sign.xaml
    /// </summary>
    public partial class Sign : UserControl
    {
        public Sign()
        {
            InitializeComponent();
        }

         private void GoSign(object sender, RoutedEventArgs e)
        {
            if (loginField.Text == "EGOR" && passwordField.Password == "EGOR")
            {
                ActiveUser.UserId = 0;
                ActiveUser.UserLogin = "EGOR";
                ActiveUser.UserName = "EGOR";
                ActiveUser.DateRegistr = "0.0.0";
                ActiveUser.UserPassword = passwordField.Password;
                InitializeWindows.mm = new MainMenu();
                InitializeWindows.mm.DataContext = new StartMainMenu();
                InitializeWindows.mm.playerName.Content = ActiveUser.UserName;
                InitializeWindows.mm.Show();
                InitializeWindows.mw.Close();
                InitializeWindows.mw = new MainWindow();
            }
            else
            {
                UsersRepository ur = UsersRepository.Initialize();
                ur.Sign(loginField.Text, passwordField.Password);
            }

       }

        private void GoSign_l(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new StartMainMenu();
            InitializeWindows.mm.playerName.Content = "EGOR";

        }



        private void GoToReg(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mw.DataContext = new Registration();
        }

        private void ExitWindow(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mw.Close();
            InitializeWindows.mw = new MainWindow();

        }

        private void MineGame(object sender, RoutedEventArgs e)
        {
            InitializeWindows.ms = new Minesweeper.WPF.Mine();
            InitializeWindows.ms.Show();
        }

        private void TetrisGame(object sender, RoutedEventArgs e)
        {

            ActiveUser.UserName = "EGOR";
            InitializeWindows.mm = new MainMenu();
            InitializeWindows.mm.DataContext = new StartMainMenu();
            InitializeWindows.mm.playerName.Content = ActiveUser.UserName;
            InitializeWindows.mm.Show();
            InitializeWindows.mw.Close();
            InitializeWindows.mw = new MainWindow();
        }
        private void SwitchGame(object sender, RoutedEventArgs e)
        {
            InitializeWindows.sw = new Puzzle.Switch();
            InitializeWindows.sw.Show();
        }

        private void BallGame(object sender, RoutedEventArgs e)
        {
            InitializeWindows.bl = new Game.Game_Ball();
            InitializeWindows.bl.Show();
        }

        private void loginField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
