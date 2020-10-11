using System;
using StopWatch;

namespace csharp_oop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Watch();

            stopWatch.Start();
            stopWatch.Stop(new TimeSpan(2, 5, 30));
            Console.WriteLine(stopWatch.Timer);

            stopWatch.Start();
            stopWatch.Stop(0, 5, 12);
            Console.WriteLine(stopWatch.Timer);

            stopWatch.Reset();
            Console.WriteLine(stopWatch.Timer);
        }
    }
}
