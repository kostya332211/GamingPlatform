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
    /// Логика взаимодействия для MenuStats.xaml
    /// </summary>
    public partial class MenuStats : UserControl
    {
        public MenuStats()
        {
            InitializeComponent();
        }
        public void GoToHome(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new StartMainMenu();
        }

        private void StatsGameSnake(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new ShowStats(GamesStats.Snake);
        }

        private void StatsGameMemory(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new ShowStats(GamesStats.MemoryCards);
        }


        private void StatsGameMine(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new ShowStats(GamesStats.Mines);
        }
        private void StatsGameTetris(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new ShowStats(GamesStats.Tetris);
        }
        private void StatsGameSwitch(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new ShowStats(GamesStats.Switch);
        }
        private void StatsGameBall(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new ShowStats(GamesStats.Ball);
        }
    }
}
