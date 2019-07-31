using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingPlatform.AllLogic;

namespace GamingPlatform.Games.MemoryCards.ViewModels
{
    public class GameVM : ObservableObject
    {

        public SlideCollectionVM Slides { get; private set; }

        public GameInfoVM GameInfo { get; private set; }


        public GameVM()
        {
            SetupGame();
        }
        private void SetupGame()
        {

            Slides = new SlideCollectionVM();
            GameInfo = new GameInfoVM();

            GameInfo.ClearInfo();

            Slides.CreateSlides("Pictures/Memes");
            Slides.Memorize();

            OnPropertyChanged("Slides");
            OnPropertyChanged("GameInfo");
        }
        public void ClickedSlide(object slide)
        {
            if (Slides.canSelect)
            {
                var selected = slide as PictureVM;
                Slides.SelectSlide(selected);
            }

            if (!Slides.areSlidesActive)
            {
                if (Slides.CheckIfMatched())
                    GameInfo.Award(); 
                else
                    GameInfo.Penalize();
            }

            GameStatus();
        }

        private void GameStatus()
        {
            if (GameInfo.MatchAttempts < 0)
            {
                GameInfo.GameStatus(false);
                Slides.RevealUnmatched();
            }

            if (Slides.AllSlidesMatched)
            {
                
                GameInfo.GameStatus(true);
            }
        }


        public void Restart()
        {
            SetupGame();
        }
    }
}
