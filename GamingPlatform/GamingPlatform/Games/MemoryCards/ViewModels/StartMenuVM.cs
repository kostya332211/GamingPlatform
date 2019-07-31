using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingPlatform.Games.MemoryCards.ViewModels
{

    class StartMenuVM
    {

        private MainWindowV mainWindow;
        public StartMenuVM(MainWindowV main)
        {
            mainWindow = main;
        }

        public void StartNewGame()
        {
            GameVM newGame = new GameVM();
            mainWindow.DataContext = newGame;
        }
    }
}
