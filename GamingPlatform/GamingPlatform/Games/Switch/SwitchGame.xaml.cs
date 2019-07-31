using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Threading.Tasks;
using GamingPlatform.AllLogic;

namespace Puzzle
{
    public partial class Switch : Window
    {
        public int schet = 0;//Score for KOSTY
        public string schet_str;

        const int gridSize = 4;
        public ObservableCollection<int> Cells { get; private set; } = new ObservableCollection<int>();

        public Switch()
        {

            InitializeComponent();
            DataContext = Cells;
            Fill();
        }

        async void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            int val = (int)e.Parameter;
            DoAction(val, (canMove, zero, cur) => {

                Debug.WriteLine($"Diff = {zero - cur}; ({cur} + 1) % 4 = {(cur + 1) % 4}; curIndex - zero = {cur - zero}");

                if (canMove)
                {
                    Cells[zero] = val;
                    Cells[cur] = 0;
                    schet = schet + 1;

                }
            });

            if (IsCorrect())
            {
                MessageBox.Show("Congratulation, you win!", "Puzzle", MessageBoxButton.OK, MessageBoxImage.Information);

                SwitchRepository sr = SwitchRepository.Initialize();
                await Task.Run(() => { sr.WriteResult(schet); });

                schet_str = Convert.ToString(schet); //Score for KOSTY
                MessageBox.Show(schet_str);
            }
        }

        void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            DoAction((int)e.Parameter, (canMove, zero, cur) => e.CanExecute = canMove);
        }

        void Fill()
        {
            var random = new Random();
            var size = gridSize * gridSize;
            var list = Enumerable.Range(0, size).ToList();

            while (list.Count > 0)
            {
                int index = random.Next(0, list.Count - 1);
                Cells.Add(list[index]);
                list.RemoveAt(index);
            }
        }

        public bool IsCorrect()
        {
            for (int i = 0; i < Cells.Count; ++i)
                if (Cells[i] != i)
                    return false;
            return true;
        }

        public void DoAction(int current, Action<bool, int, int> action)
        {
            var zeroIndex = 0;
            var curIndex = 0;
            var canMove = false;

            for (int i = 0; i < Cells.Count; ++i)
            {
                if (Cells[i] == 0)
                    zeroIndex = i;

                if (Cells[i] == current)
                    curIndex = i;
            }

            var diff = curIndex - zeroIndex;
            var column = (curIndex + 1) % gridSize;

            if (diff == gridSize) canMove = true;
            else if (diff == -gridSize) canMove = true;
            else if (diff == 1) canMove = column != 1;
            else if (diff == -1) canMove = column != 0;

            action(canMove, zeroIndex, curIndex);
        }
    }
}