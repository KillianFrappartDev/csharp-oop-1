using System;
using Ex.StopWatch;
using Ex.StackOverflow;

namespace csharp_oop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();

            stopWatch.Start();
            stopWatch.Stop(new TimeSpan(2, 5, 30));
            Console.WriteLine(stopWatch.Timer);

            stopWatch.Start();
            stopWatch.Stop(0, 5, 12);
            Console.WriteLine(stopWatch.Timer);

            stopWatch.Reset();
            Console.WriteLine(stopWatch.Timer);

            var post = new StackOverflow("First Post", "This is a post...");
            Console.WriteLine($"{post.Title} - {post.Description} - {post.Date} - {post.Votes}");

            post.UpVote();
            post.UpVote();
            post.UpVote();
            Console.WriteLine($"{post.Title} - {post.Description} - {post.Date} - {post.Votes}");

            post.DownVote();
            post.DownVote();
            Console.WriteLine($"{post.Title} - {post.Description} - {post.Date} - {post.Votes}");
        }
    }
}
