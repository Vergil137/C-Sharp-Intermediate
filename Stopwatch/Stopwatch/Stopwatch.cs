using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _stop;
        private bool _running;

        public TimeSpan Duration => _stop.Subtract(_start);

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("The Stopwatch can not be started Twice in a Row.");

            _running = true;
            _start = DateTime.Now;
        }

        public void Stop()
        {
            _running = false;
            _stop = DateTime.Now;
        }
    }
}
