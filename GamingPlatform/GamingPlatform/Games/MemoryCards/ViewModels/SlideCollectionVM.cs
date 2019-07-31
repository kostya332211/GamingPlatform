using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;   
using System.Windows.Threading;
using GamingPlatform.Games.MemoryCards.Models;
using System.IO;

namespace GamingPlatform.Games.MemoryCards.ViewModels
{
    public class SlideCollectionVM : ObservableObject
    {
        public ObservableCollection<PictureVM> MemorySlides { get; private set; }


        private PictureVM SelectedSlide1;
        private PictureVM SelectedSlide2;

  
        private DispatcherTimer peekTimer;
        private DispatcherTimer openingTimer;


        private const int peekSeconds = 1;

        private const int openSeconds = 3;


        public bool areSlidesActive
        {
            get
            {
                if (SelectedSlide1 == null || SelectedSlide2 == null)
                    return true;

                return false;
            }
        }


        public bool AllSlidesMatched
        {
            get
            {
                foreach (var slide in MemorySlides)
                {
                    if (!slide.isMatched)
                        return false;
                }

                return true;
            }
        }

 
        public bool canSelect { get; private set; }


        public SlideCollectionVM()
        {
            peekTimer = new DispatcherTimer();
            peekTimer.Interval = new TimeSpan(0, 0, peekSeconds);
            peekTimer.Tick += PeekTimer_Tick;

            openingTimer = new DispatcherTimer();
            openingTimer.Interval = new TimeSpan(0, 0, openSeconds);
            openingTimer.Tick += OpeningTimer_Tick;
        }

 
        public void CreateSlides(string imagesPath)
        {

            MemorySlides = new ObservableCollection<PictureVM>();
            var models = GetModelsFrom(imagesPath);


            for (int i = 0; i < 6; i++)
            {
 
                var newSlide = new PictureVM(models[i]);
                var newSlideMatch = new PictureVM(models[i]);

                MemorySlides.Add(newSlide);
                MemorySlides.Add(newSlideMatch);

                newSlide.PeekAtImage();
                newSlideMatch.PeekAtImage();
            }

            ShuffleSlides();
            OnPropertyChanged("MemorySlides");
        }

    
        public void SelectSlide(PictureVM slide)
        {
            slide.PeekAtImage();

            if (SelectedSlide1 == null)
            {
                SelectedSlide1 = slide;
            }
            else if (SelectedSlide2 == null)
            {
                SelectedSlide2 = slide;
                HideUnmatched();
            }

            OnPropertyChanged("areSlidesActive");
        }


        public bool CheckIfMatched()
        {
            if (SelectedSlide1.Id == SelectedSlide2.Id)
            {
                MatchCorrect();
                return true;
            }
            else
            {
                MatchFailed();
                return false;
            }
        }


        private void MatchFailed()
        {
            SelectedSlide1.MarkFailed();
            SelectedSlide2.MarkFailed();
            ClearSelected();
        }


        private void MatchCorrect()
        {
            SelectedSlide1.MarkMatched();
            SelectedSlide2.MarkMatched();
            ClearSelected();
        }


        private void ClearSelected()
        {
            SelectedSlide1 = null;
            SelectedSlide2 = null;
            canSelect = false;
        }

        public void RevealUnmatched()
        {
            foreach (var slide in MemorySlides)
            {
                if (!slide.isMatched)
                {
                    peekTimer.Stop();
                    slide.MarkFailed();
                    slide.PeekAtImage();
                }
            }
        }


        public void HideUnmatched()
        {
            peekTimer.Start();
        }


        public void Memorize()
        {
            openingTimer.Start();
        }


        private List<PictureModel> GetModelsFrom(string relativePath)
        {
 
            var models = new List<PictureModel>();

            var images = Directory.GetFiles(relativePath, "*.jpg", SearchOption.AllDirectories);

            var id = 0;

            foreach (string i in images)
            {
                models.Add(new PictureModel() { Id = id, ImageSource = "E:\\GamingPlatform\\GamingPlatform\\Games\\MemoryCards\\" + i });
                id++;
            }

            return models;
        }


        private void ShuffleSlides()
        {

            var rnd = new Random();

            for (int i = 0; i < 64; i++)
            {
                MemorySlides.Reverse();
                int aa = rnd.Next(0, MemorySlides.Count);
                int bb = rnd.Next(0, MemorySlides.Count);
                MemorySlides.Move(aa, bb);
            }
        }


        private void OpeningTimer_Tick(object sender, EventArgs e)
        {
            foreach (var slide in MemorySlides)
            {
                slide.ClosePeek();
                canSelect = true;
            }
            OnPropertyChanged("areSlidesActive");
            openingTimer.Stop();
        }


        private void PeekTimer_Tick(object sender, EventArgs e)
        {
            foreach (var slide in MemorySlides)
            {
                if (!slide.isMatched)
                {
                    slide.ClosePeek();
                    canSelect = true;
                }
            }
            OnPropertyChanged("areSlidesActive");
            peekTimer.Stop();
        }
    }
}
