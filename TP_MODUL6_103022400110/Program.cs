using System;
using TP_MODUL6_103022400110;

class Program
{
    static void Main(string[] args)
    {
        // TEST CASES
        try
        {
            Console.WriteLine("=== TEST NORMAL ===");
            SayaMusicTrack track1 = new SayaMusicTrack("My Favorite Song");
            track1.IncreasePlayCount(5000);
            track1.PrintTrackDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // TEST CASES FOR EXCEPTIONS
        try
        {
            Console.WriteLine("=== TEST TITLE > 100 ===");
            string longTitle = new string('A', 101);
            SayaMusicTrack track2 = new SayaMusicTrack(longTitle);
            track2.PrintTrackDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // TEST CASES FOR EXCEPTIONS
        try
        {
            Console.WriteLine("=== TEST PLAYCOUNT > 10.000.000 ===");
            SayaMusicTrack track3 = new SayaMusicTrack("Overflow Test Song");
            track3.IncreasePlayCount(15000000);
            track3.PrintTrackDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}