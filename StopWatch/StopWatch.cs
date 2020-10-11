using System;

namespace StopWatch
{
    public class Watch
    {
        private bool IsRunning { get; set; }
        public TimeSpan Timer { get; set; }

        public Watch()
        {
            this.IsRunning = false;
            this.Timer = new TimeSpan();
        }

        public void Start()
        {
            if (IsRunning) throw new System.InvalidOperationException();
            else IsRunning = true;
        }

        public TimeSpan Stop(TimeSpan timeSpan)
        {
            if (!IsRunning) throw new System.InvalidOperationException();
            else
            {
                IsRunning = false;
                return Timer = Timer + timeSpan;
            }
        }

        public TimeSpan Stop(int hours, int minutes, int seconds)
        {
            if (!IsRunning) throw new System.InvalidOperationException();
            else
            {
                IsRunning = false;
                return Timer = Timer + new TimeSpan(hours, minutes, seconds);
            }
        }

        public void Reset()
        {
            IsRunning = false;
            Timer = new TimeSpan();
        }
    }
}