using TP_MODUL6_103022400110;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of SayaMusicTrack and test the methods
        SayaMusicTrack track = new SayaMusicTrack("My Favorite Song");
        track.IncreasePlayCount(2);
        track.PrintTrackDetails();
    }
}