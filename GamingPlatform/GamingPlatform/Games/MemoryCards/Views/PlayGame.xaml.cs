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
using GamingPlatform.Games.MemoryCards.ViewModels;


namespace GamingPlatform.Games.MemoryCards.Views
{
    /// <summary>
    /// Логика взаимодействия для PlayGame.xaml
    /// </summary>
    public partial class PlayGame : UserControl
    {
        public PlayGame()
        {
            InitializeComponent();
        }
        private void Slide_Clicked(object sender, RoutedEventArgs e)
        {
            var game = DataContext as GameVM;
            var button = sender as Button;
            game.ClickedSlide(button.DataContext);
        }

        private void PlayAgain_C(object sender, RoutedEventArgs e)
        {
            var game = DataContext as GameVM;
            game.Restart();
        }
    }
}
