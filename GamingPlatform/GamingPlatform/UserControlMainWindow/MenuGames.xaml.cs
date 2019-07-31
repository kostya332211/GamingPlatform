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
using GamingPlatform.Games.Snake;
namespace GamingPlatform.UserControlMainWindow
{
    /// <summary>
    /// Логика взаимодействия для MenuGames.xaml
    /// </summary>
    public partial class MenuGames : UserControl
    {
        public MenuGames()
        {
            InitializeComponent();
        }

        public void GoToHome(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new StartMainMenu();
        }

        private void StartGameSnake(object sender, RoutedEventArgs e)
        {
            InitializeWindows.sc = new Games.Snake.SnakeCanvas();
            InitializeWindows.sc.nameUser.Text = ActiveUser.UserName;
            InitializeWindows.sc.Show();
        }

        private void StartGameMemory(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mg = new Games.MemoryCards.MainWindowV();
            InitializeWindows.mg.Show();
        }

        private void StartTicTacGame(object sender, RoutedEventArgs e)
        {
            InitializeWindows.tt = new Games.TicTacToe.TicTacWindow();
            InitializeWindows.tt.Show();
        }

        private void MineGame(object sender, RoutedEventArgs e)
        {
            InitializeWindows.ms = new Minesweeper.WPF.Mine();
            InitializeWindows.ms.Show();
        }

        private void TetrisGame(object sender, RoutedEventArgs e)
        {
            InitializeWindows.ts = new Tetris.Tetris();
            InitializeWindows.ts.Show();
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

        
    }
}
