using System;

namespace Assignment
{
    public class Clock
    {
        private readonly int _second;
        public delegate void clockTickHandler(object clock, ClockEventArgs clockEventArgs);
        public event clockTickHandler? clockTickEvent;

        protected void OnTick(object clock, ClockEventArgs clockTickHandler)
        {
            if (clockTickEvent != null)
            {
                clockTickEvent(clock, clockTickHandler);
            }
        }

        public void Run()
        {
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(1000);
                var time = DateTime.Now;

                if (time.Second != _second)
                {
                    var clockEventArgs = new ClockEventArgs(time.Hour, time.Minute, time.Second);
                    OnTick(this, clockEventArgs);
                }
            }
        }
    }
}