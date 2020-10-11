using System;

namespace Ex.StackOverflow
{
    public class StackOverflow
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Votes { get; private set; }
        public DateTime Date { get; private set; }

        public StackOverflow(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.Votes = 0;
            this.Date = DateTime.Now;
        }

        public void UpVote() => Votes++;
        public void DownVote() => Votes--;

    }
}