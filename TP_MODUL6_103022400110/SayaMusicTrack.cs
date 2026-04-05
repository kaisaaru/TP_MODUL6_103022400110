using System;

namespace TP_MODUL6_103022400110
{
    class SayaMusicTrack
    {
        // Properties
        private int id;
        private string playCount;
        private string title;

        // Constructor
        public SayaMusicTrack(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 100000); // 5 digit
            this.playCount = "0";
            this.title = title;
        }

        // Methods
        public void IncreasePlayCount(int count)
        {
            // Convert playCount to integer, add count, and convert back to string
            int currentPlayCount = int.Parse(playCount);
            currentPlayCount += count;
            playCount = currentPlayCount.ToString();
        }

        public void PrintTrackDetails()
        {
            // Print the track details
            Console.WriteLine("Track Details:");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}