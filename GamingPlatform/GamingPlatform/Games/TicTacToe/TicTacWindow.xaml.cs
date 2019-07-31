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
using System.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GamingPlatform.AllLogic;
using System.Data.Entity.Validation;

namespace GamingPlatform.Games.TicTacToe
{
    public class Position : INotifyPropertyChanged
    {
        public int CheckWinLose()
        {
            char lit = 'n';
            if (FEN.IndexOf('0')<0) {
                return 3;
            }
            for (int i = 1; i <= 3; i++)
            {
                if ((FEN[i] == FEN[i + 3]) && (FEN[i + 3] == FEN[i + 6]) && FEN[i] != '0')
                {
                    lit = FEN[i];
                }
            }
            for (int i = 1; i <= 9; i = i + 3)
            {
                if ((FEN[i] == FEN[i + 1]) && (FEN[i + 1] == FEN[i + 2]) && FEN[i] != '0')
                {
                    lit = FEN[i];
                }
            }
            
            if((FEN[1] == FEN[5]) && (FEN[5] == FEN[9]) && FEN[5] != '0')
            {
                lit = fen[1];
            }

            else if((FEN[3] == FEN[5]) && (FEN[5] == FEN[7]) && FEN[5] != '0')
            {
                lit = FEN[3];
            }
            if (lit == '1')
            {
                return 1;
            }
            else if (lit == '2')
            {
                return 2;
            }
            return 0;
        }
        public void Draw()
        {

            if (fen[1] == '1') { P1 = "X"; }
            else if (fen[1] == '2') { P1 = "0"; }

            if (fen[2] == '1') { P2 = "X"; }
            else if (fen[2] == '2') { P2 = "0"; }

            if (fen[3] == '1') { P3 = "X"; }
            else if (fen[3] == '2') { P3 = "0"; }

            if (fen[4] == '1') { P4 = "X"; }
            else if (fen[4] == '2') { P4 = "0"; }

            if (fen[5] == '1') { P5 = "X"; }
            else if (fen[5] == '2') { P5 = "0"; }

            if (fen[6] == '1') { P6 = "X"; }
            else if (fen[6] == '2') { P6 = "0"; }

            if (fen[7] == '1') { P7 = "X"; }
            else if (fen[7] == '2') { P7 = "0"; }

            if (fen[8] == '1') { P8 = "X"; }
            else if (fen[8] == '2') { P8 = "0"; }

            if (fen[9] == '1') { P9 = "X"; }
            else if (fen[9] == '2') { P9 = "0"; }
        }
        public bool yourMove;
        public string fen;
        public decimal price;
        public int idTable;
        public string user1;
        public string user2;
        public string p1 = "";
        public string p2 = "";
        public string p3 = "";
        public string p4 = "";
        public string p5 = "";
        public string p6 = "";
        public string p7 = "";
        public string p8 = "";
        public string p9 = "";
        public string FEN
        {
            get { return fen; }
            set
            {
                fen = value; OnPropertyChanged("FEN");

                Draw();
            }

        }

        public int IDTable { get { return idTable; } set { idTable = value; OnPropertyChanged("IDTable"); } }
        public string User1 { get { return user1; } set { user1 = value; OnPropertyChanged("User1"); } }
        public string User2 { get { return user2; } set { user2 = value; OnPropertyChanged("User2"); } }

        public string P1 { get { return p1; } set { p1 = value; OnPropertyChanged("P1"); } }
        public string P2 { get { return p2; } set { p2 = value; OnPropertyChanged("P2"); } }
        public string P3 { get { return p3; } set { p3 = value; OnPropertyChanged("P3"); } }
        public string P4 { get { return p4; } set { p4 = value; OnPropertyChanged("P4"); } }
        public string P5 { get { return p5; } set { p5 = value; OnPropertyChanged("P5"); } }
        public string P6 { get { return p6; } set { p6 = value; OnPropertyChanged("P6"); } }
        public string P7 { get { return p7; } set { p7 = value; OnPropertyChanged("P7"); } }
        public string P8 { get { return p8; } set { p8 = value; OnPropertyChanged("P8"); } }
        public string P9 { get { return p9; } set { p9 = value; OnPropertyChanged("P9"); } }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }



    public partial class TicTacWindow : Window
    {
        public static TicTacWindow win { get; set; }
        public Position position { get; set; }

        public TicTacWindow()
        {


            win = this;
            InitializeComponent();
            position = new Position
            {
                IDTable = 0,
            };


            win.DataContext = position;


        }

        public void Play()
        {
            int IDEmptyUser = 6;
            
                while (true)
            {
                using (GamingPlatformDB_v4Entities d = new GamingPlatformDB_v4Entities())
                {

                    List<TicTacMatch> list = d.TicTacMatches.ToList();
                    List<Player> listP = d.Players.ToList();
                    TicTacMatch result = new TicTacMatch();
                    Player player = new Player();
                    player = listP.Find(item => item.IDPlayer == ActiveUser.UserId);
                    if (position.IDTable==0)
                    {
                        result = list.Find(item => item.StatusMatch == 0); //0-wait, 1-play 2-
                        position.IDTable = result.IDTable;
                        if (result.Player.IDPlayer == IDEmptyUser)     //left user
                        {
                            position.yourMove = true;
                            result.Player = player;
                            position.User1 = result.Player.LoginUser;
                        }
                        else if(result.Player1.IDPlayer == IDEmptyUser)
                        {
                            position.yourMove = false;
                            position.User2 = result.Player1.LoginUser;
                            result.Player1 = player;
                            result.StatusMatch = 1;
                        }
                        
                    }
                    else
                    {
                        result = list.Find(item => item.IDTable == position.IDTable);
                        position.FEN = result.FEN;
                        position.User1 = result.Player.LoginUser;
                        position.User2 = result.Player1.LoginUser;
                        if (position.CheckWinLose() == 1)
                        {
                            MessageBox.Show(position.User1 + " победил");
                            break;
                        }
                        else if (position.CheckWinLose() == 2)
                        {
                            MessageBox.Show(position.User2 + " победил");
                            break;
                        }
                        else if (position.CheckWinLose() == 3)
                        {
                            MessageBox.Show("ничья");
                            break;
                        }
                    }
                    
                    d.SaveChanges();
      

                   


                }
            }

        }
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => { Play(); });
        }

        public void WriteInDB(int numberButton)
        {
            using (GamingPlatformDB_v4Entities writeMove = new GamingPlatformDB_v4Entities())
            {
                List<TicTacMatch> list = writeMove.TicTacMatches.ToList();
                TicTacMatch result = new TicTacMatch();
                result = list.Find(item => item.IDTable == position.IDTable);
                try
                {
                    writeMove.SaveChanges();
                }
                catch (DbEntityValidationException d)
                {
                    MessageBox.Show(d.Message);
                }

                char[] str = result.FEN.ToCharArray();
                StringBuilder stringBuilder = new StringBuilder(result.FEN);

                if (stringBuilder[0] == 'K')
                {
                    stringBuilder[0] = 'N';
                    stringBuilder[numberButton] = '1';
                }
                else if (stringBuilder[0] == 'N')
                {
                    stringBuilder[0] = 'K';
                    stringBuilder[numberButton] = '2';
                }

                result.FEN = stringBuilder.ToString();
                writeMove.SaveChanges();

            }
        }
        private void b0_Click(object sender, RoutedEventArgs e)
        {
            if ((position.yourMove == true && position.FEN[0]=='K')||(position.yourMove == false && position.FEN[0] == 'N'))
            {
                WriteInDB(Convert.ToInt32(Convert.ToString((sender as Button).Name[1])));
            }
        }

    }
}
