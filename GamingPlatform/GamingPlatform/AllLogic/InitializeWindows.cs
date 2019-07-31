using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GamingPlatform.AllLogic
{
    public class InitializeWindows
    {
        public static GamingPlatform.UserControlMainWindow.MainMenu mm;
        public static GamingPlatform.Games.MemoryCards.MainWindowV mg;
        public static GamingPlatform.UserControlMainWindow.MainWindow mw;
        public static Games.Snake.SnakeCanvas sc;
        public static Minesweeper.WPF.Mine ms;
        public static Tetris.Tetris ts;
        public static Puzzle.Switch sw;
        public static Game.Game_Ball bl;

        public static Games.TicTacToe.TicTacWindow tt;
        public static void InitWindows()
        {
            sc = new Games.Snake.SnakeCanvas();
        }
        public static void InitWindows_1()
        {
            ts = new Tetris.Tetris();
        }

        public  static void CloseAllWindows()
        {
            mm.Close();
            mw.Close();
            sc.Close();
            mg.Close();
            tt.Close();
            ms.Close();
            ts.Close();
            sw.Close();
            bl.Close();
        }
    }
}
