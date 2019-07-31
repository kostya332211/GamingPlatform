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
    public enum GamesStats
    {
        Ball,
        Mines,
        Switch,
        Tetris,
        Snake,
        MemoryCards,
        TicTacToe
    }
    /// <summary>
    /// Логика взаимодействия для ShowStats.xaml
    /// </summary>
    public partial class ShowStats : UserControl
    {
        //private GamesStats game;
        public ShowStats(GamesStats game)
        {
            InitializeComponent();
            using (GamingPlatformDB_v4Entities entities = new GamingPlatformDB_v4Entities())
            {
                List<GameBall> gameBall;
                List<GameSwitch> gameSwitch;
                List<GameMine> gameMine;
                List<GameTetri> gameTetris;
                List<SnakeGame> gameSnake;
                List<MemoryCardsGame> gameMemoryCards;
                switch (game)
                {
                    
                    case GamesStats.Ball:
                        gameBall = entities.GameBalls.OrderByDescending(s => s.BestScore).ToList();
                        nameGame.Text = "Ball";
                        place1.Text = "1. " + gameBall[0].Player.LoginUser + "(" + gameBall[0].BestScore + ")";
                        place2.Text = "2. " + gameBall[1].Player.LoginUser + "(" + gameBall[1].BestScore + ")";
                        place3.Text = "3. " + gameBall[2].Player.LoginUser + "(" + gameBall[2].BestScore + ")";
                        place4.Text = "4. " + gameBall[3].Player.LoginUser + "(" + gameBall[3].BestScore + ")";
                        break;
                    case GamesStats.Mines:
                        gameMine = entities.GameMines.OrderBy(s => s.BestScore).ToList();
                        nameGame.Text = "Switch";
                        place1.Text = "1. " + gameMine[0].Player.LoginUser + "(" + gameMine[0].BestScore + ")";
                        place2.Text = "2. " + gameMine[1].Player.LoginUser + "(" + gameMine[1].BestScore + ")";
                        place3.Text = "3. " + gameMine[2].Player.LoginUser + "(" + gameMine[2].BestScore + ")";
                        place4.Text = "4. " + gameMine[3].Player.LoginUser + "(" + gameMine[3].BestScore + ")";
                        break;
                    case GamesStats.Tetris:
                        gameTetris = entities.GameTetris.OrderByDescending(s => s.BestScore).ToList();
                        nameGame.Text = "Tetris";
                        place1.Text = "1. " + gameTetris[0].Player.LoginUser + "(" + gameTetris[0].BestScore + ")";
                        place2.Text = "2. " + gameTetris[1].Player.LoginUser + "(" + gameTetris[1].BestScore + ")";
                        place3.Text = "3. " + gameTetris[2].Player.LoginUser + "(" + gameTetris[2].BestScore + ")";
                        place4.Text = "4. " + gameTetris[3].Player.LoginUser + "(" + gameTetris[3].BestScore + ")";
                        break;
                    case GamesStats.Switch:
                        gameSwitch = entities.GameSwitches.OrderBy(s => s.BestScore).ToList();
                        nameGame.Text = "Minesweapper";
                        place1.Text = "1. " + gameSwitch[0].Player.LoginUser + "(" + gameSwitch[0].BestScore + ")";
                        place2.Text = "2. " + gameSwitch[1].Player.LoginUser + "(" + gameSwitch[1].BestScore + ")";
                        place3.Text = "3. " + gameSwitch[2].Player.LoginUser + "(" + gameSwitch[2].BestScore + ")";
                        place4.Text = "4. " + gameSwitch[3].Player.LoginUser + "(" + gameSwitch[3].BestScore + ")";
                        break;
                    case GamesStats.Snake:
                        gameSnake = entities.SnakeGames.OrderByDescending(s => s.BestScore).ToList();
                        nameGame.Text = "Snake";
                        place1.Text = "1. " + gameSnake[0].Player.LoginUser + "(" + gameSnake[0].BestScore + ")";
                        place2.Text = "2. " + gameSnake[1].Player.LoginUser + "(" + gameSnake[1].BestScore + ")";
                        place3.Text = "3. " + gameSnake[2].Player.LoginUser + "(" + gameSnake[2].BestScore + ")";
                        place4.Text = "4. " + gameSnake[3].Player.LoginUser + "(" + gameSnake[3].BestScore + ")";
                        break;
                    case GamesStats.MemoryCards:
                        gameMemoryCards = entities.MemoryCardsGames.OrderByDescending(s => s.BestScore).ToList();
                        nameGame.Text = "MemoryCards";
                        place1.Text = "1. " + gameMemoryCards[0].Player.LoginUser + "(" + gameMemoryCards[0].BestScore + ")";
                        place2.Text = "2. " + gameMemoryCards[1].Player.LoginUser + "(" + gameMemoryCards[1].BestScore + ")";
                        place3.Text = "3. " + gameMemoryCards[2].Player.LoginUser + "(" + gameMemoryCards[2].BestScore + ")";
                        place4.Text = "4. " + gameMemoryCards[3].Player.LoginUser + "(" + gameMemoryCards[3].BestScore + ")";
                        break;

                }
            }

        }

        public void GoToHome(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mm.DataContext = new MenuStats();
        }
    }
}
