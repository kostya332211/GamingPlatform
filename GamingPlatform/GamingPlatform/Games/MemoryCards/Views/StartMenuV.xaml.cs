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
    /// Логика взаимодействия для StartMenuV.xaml
    /// </summary>
    public partial class StartMenuV : UserControl
    {
        public StartMenuV()
        {
            InitializeComponent();
        }
        private void Play_Clicked(object sender, RoutedEventArgs e)
        {
            var startMenu = DataContext as StartMenuVM;
            startMenu.StartNewGame();
        }
    }
}
