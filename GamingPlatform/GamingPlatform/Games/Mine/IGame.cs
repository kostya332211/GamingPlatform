using System;

namespace Minesweeper.WPF
{
    public interface IGame
    {
        
        event EventHandler CounterChanged;
        event EventHandler TimerThresholdReached;
        event EventHandler<PlateEventArgs> ClickPlate;

        void Run();
    }
}
