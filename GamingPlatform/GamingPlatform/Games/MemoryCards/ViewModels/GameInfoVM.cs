using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GamingPlatform.AllLogic;
namespace GamingPlatform.Games.MemoryCards.ViewModels
{
    public class GameInfoVM : ObservableObject
    {

        private const int maxAttempts = 4;
        private const int pointAward = 75;
        private const int pointDeduction = 15;

        private int matchAttempts;
        private int score;

        private bool gameLost;
        private bool gameWon;

        public int MatchAttempts
        {
            get
            {
                return matchAttempts;
            }
            private set
            {
                matchAttempts = value;
                OnPropertyChanged("MatchAttempts");
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            private set
            {
                score = value;
                OnPropertyChanged("Score");
            }
        }

        public Visibility LostMessage
        {
            get
            {
                if (gameLost)
                    return Visibility.Visible;

                return Visibility.Hidden;
            }
        }

        public Visibility WinMessage
        {
            get
            {
                if (gameWon)
                    return Visibility.Visible;

                return Visibility.Hidden;
            }
        }

        public void GameStatus(bool win)
        {
            MemoryCardsRepository mcr = MemoryCardsRepository.Initialize();
            mcr.WriteResult(score);
            if (!win)
            {
                gameLost = true;
                OnPropertyChanged("LostMessage");
            }

            if (win)
            {
                gameWon = true;
                OnPropertyChanged("WinMessage");
            }
        }

        public void ClearInfo()
        {
            Score = 0;
            MatchAttempts = maxAttempts;
            gameLost = false;
            gameWon = false;
            OnPropertyChanged("LostMessage");
            OnPropertyChanged("WinMessage");
        }

        public void Award()
        {
            Score += pointAward;
        }

        public void Penalize()
        {
            Score -= pointDeduction;
            MatchAttempts--;
        }
    }
}
