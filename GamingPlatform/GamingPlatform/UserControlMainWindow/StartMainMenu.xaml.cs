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
    /// Логика взаимодействия для StartMainMenu.xaml
    /// </summary>
    public partial class StartMainMenu : UserControl
    {
        
        public StartMainMenu()
        {
            InitializeComponent();
        }

        private void Profile_MouseEnter(object sender, MouseEventArgs e)
        {

            Profile.Foreground = Brushes.Black;
        }

        private void Profile_MouseLeave(object sender, MouseEventArgs e)
        {
            Profile.Foreground = Brushes.Gray;
        }

        private void Statistics_MouseEnter(object sender, MouseEventArgs e)
        {
            Statistics.Foreground = Brushes.Black;
        }

        private void Statistics_MouseLeave(object sender, MouseEventArgs e)
        {
            Statistics.Foreground = Brushes.Gray;
        }

        private void Games_MouseEnter(object sender, MouseEventArgs e)
        {
            Games.Foreground = Brushes.Black;
        }

        private void Games_MouseLeave(object sender, MouseEventArgs e)
        {
            Games.Foreground = Brushes.Gray;
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
  
            InitializeWindows.mm.DataContext = new MenuProfile();
        }

        private void StatsButton_Click(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new MenuStats();
        }

        private void GameButton_Click(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new MenuGames();
        }
        private void Chat_client(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new Chat();


           // InitializeWindows.cs = new Client.MainWindow();
          //  InitializeWindows.cs.Show();
        }

    }
}
