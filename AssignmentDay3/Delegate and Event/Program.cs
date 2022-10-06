using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DisplayClock displayClock = new DisplayClock();
            displayClock.Subscribe(clock);
            clock.Run();
        }
    }
}