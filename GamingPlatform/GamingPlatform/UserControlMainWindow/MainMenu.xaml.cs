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
using System.Windows.Shapes;
using GamingPlatform.AllLogic;

namespace GamingPlatform.UserControlMainWindow
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            this.DataContext = new StartMainMenu();
        }
        private void Titul_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            InitializeWindows.CloseAllWindows();
            this.Close();
            
        }

        private void GoToSign(object sender, RoutedEventArgs e)
        {
            InitializeWindows.mw.DataContext = new Sign();
            InitializeWindows.mw.Show();
            InitializeWindows.mm.Close();
        }

        private void RollUp(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        
    }
}
