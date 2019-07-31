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
    /// <summary>
    /// Логика взаимодействия для Chat.xaml
    /// </summary>
    public partial class Chat : UserControl
    {
        private ChatClient cc;
        
        public Chat()
        {
            InitializeComponent();
            cc = new ChatClient();
            this.DataContext = cc;
            try
            {
                cc.SwitchClientState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void bSend_Click(object sender, RoutedEventArgs e)
        {
            cc.SendMessageTo(tbTargetUsername.Text, tbMessage.Text);
        }

        private void tbTargetUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GoToHome(object sender, RoutedEventArgs e)
        {
            try
            {
                cc.SwitchClientState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            InitializeWindows.mm.DataContext = new StartMainMenu();
        }
    }
}
