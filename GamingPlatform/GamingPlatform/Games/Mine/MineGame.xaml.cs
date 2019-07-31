using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Minesweeper.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Mine : Window
    {
        private int nrMines;
        public MinesGrid Mines { get; private set; }
        private bool gameStarted;
        private Color[] mineText;


        public void Result()
        {
            string s = TimeIndicator.Text;
        }

        public Mine()
        {
            InitializeComponent();
            gameStarted = false;
            this.nrMines = 1;
            mineText = new Color[] {Colors.White ,
                                    Colors.Blue, Colors.DarkGreen, Colors.Red, Colors.DarkBlue,
                                    Colors.DarkViolet, Colors.DarkCyan, Colors.Brown, Colors.Black };
            GameSetup();
        }

        private void MenuItem_Click_New(object sender, RoutedEventArgs e)
        {
            GameSetup();
        }

        private void GameSetup()
        {
            Mines = new MinesGrid(10, 10, nrMines);
            foreach (Button btn in ButtonsGrid.Children)
            {
                btn.Content = "";
                btn.IsEnabled = true;
            }

            Mines.CounterChanged += OnCounterChanged;
            MinesIndicator.Text = nrMines.ToString();
            Mines.ClickPlate += OnClickPlate;

            Mines.TimerThresholdReached += OnTimeChanged;
            TimeIndicator.Text = "0";

            Mines.Run();
            gameStarted = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int row = ParseButtonRow(btn);
            int col = ParseButtonColumn(btn);
            if (!Mines.IsInGrid(row, col)) throw new MinesweeperException("Invalid Button to MinesGrid reference on reveal");

            if (Mines.IsFlagged(row, col)) return;

            btn.IsEnabled = false;
            if (Mines.IsBomb(row, col))
            {

                StackPanel sp = new StackPanel();
                sp.Orientation = Orientation.Horizontal;
                Image bombImage = new Image();
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(@"Bomb.png", UriKind.Relative);
                bi.EndInit();
                bombImage.Source = bi;
                sp.Children.Add(bombImage);
                btn.Content = sp;
                Mines.Stop();

                if (gameStarted)
                {
                    gameStarted = false;
                    foreach (Button butn in ButtonsGrid.Children)
                    {
                        if (butn.IsEnabled) this.Button_Click(butn, e);
                    }
                }
            }
            else
            {
                int count = Mines.RevealPlate(row, col);
                if (count > 0)
                {
                    btn.Foreground = new SolidColorBrush(mineText[count]);
                    btn.FontWeight = FontWeights.Bold;
                    btn.Content = count.ToString();
                }
            }
        }

        private void Right_Button_Click(object sender, MouseButtonEventArgs e)
        {
            Button btn = (Button)sender;
            int row = ParseButtonRow(btn);
            int col = ParseButtonColumn(btn);
            if (!Mines.IsInGrid(row, col)) throw new MinesweeperException("Invalid Button to MinesGrid reference on flag");

            if (Mines.IsFlagged(row, col))
            {
                btn.Content = "";
            }
            else
            {

                StackPanel sp = new StackPanel();
                sp.Orientation = Orientation.Horizontal;
                Image flagImage = new Image();
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(@"Flag.png", UriKind.Relative);
                bi.EndInit();
                flagImage.Source = bi;
                sp.Children.Add(flagImage);
                btn.Content = sp;
            }

            Mines.FlagMine(row, col);
        }

        private int ParseButtonRow(Button btn)
        {
            if (btn.Name.IndexOf("Button") != 0) throw new MinesweeperException("Wrong button name in UI module");
            return int.Parse(btn.Name.Substring(6, (btn.Name.Length - 6) / 2));
        }

        private int ParseButtonColumn(Button btn)
        {
            if (btn.Name.IndexOf("Button") != 0) throw new MinesweeperException("Wrong button name in UI module");
            return int.Parse(btn.Name.Substring(6 + (btn.Name.Length - 6) / 2, (btn.Name.Length - 6) / 2));
        }

        private void OnCounterChanged(object sender, EventArgs e)
        {
            MinesIndicator.Text = (this.nrMines - Mines.FlaggedMines).ToString();
        }

        private void OnTimeChanged(object sender, EventArgs e)
        {
            TimeIndicator.Text = MinesGrid.TimeElapsed.ToString();

        }

        private void OnClickPlate(object sender, PlateEventArgs e)
        {
            string btnName = "Button";
            if (Mines.Width <= 10 && Mines.Height <= 10) btnName += String.Format("{0:D1}{1:D1}", e.PlateRow, e.PlateColumn);
            else btnName += String.Format("{0:D2}{1:D2}", e.PlateRow, e.PlateColumn);

            Button senderButton = (ButtonsGrid.FindName(btnName) as Button);
            if (senderButton == null) throw new MinesweeperException("Invalid Button to MinesGrid reference on multiple reveal");


            this.Button_Click(senderButton, new RoutedEventArgs());
        }
    }
}
