using System;

namespace Minesweeper.WPF
{
    interface IPlate
    {
        int RowPosition { get; }
        int ColPosition { get; }
    }
}
