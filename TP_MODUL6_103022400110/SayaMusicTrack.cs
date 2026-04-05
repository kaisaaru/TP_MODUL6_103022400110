using System;

namespace TP_MODUL6_103022400110
{
    class SayaMusicTrack
    {
        //
        private int id;
        private string playCount;
        private string title;

        // Constructor
        public SayaMusicTrack(string title)
        {
            // Precondition: title tidak boleh null dan maksimal 100 karakter
            if (title == null)
                throw new ArgumentNullException("title", "Judul track tidak boleh null");

            // Precondition: title maksimal 100 karakter
            if (title.Length > 100)
                throw new ArgumentException("Judul track maksimal 100 karakter");

            Random rand = new Random();
            this.id = rand.Next(10000, 100000); // 5 digit
            this.playCount = "0";
            this.title = title;
        }

        public void IncreasePlayCount(int count)
        {
            // Precondition: count tidak boleh negatif dan maksimal 10.000.000
            if (count < 0)
                throw new ArgumentException("Play count tidak boleh negatif");

            // Precondition: count maksimal 10.000.000
            if (count > 10000000)
                throw new ArgumentException("Penambahan play count maksimal 10.000.000");

            // Cek overflow saat menambahkan play count
            try
            {
                int currentPlayCount = int.Parse(playCount);

                // Gunakan checked untuk mendeteksi overflow
                checked
                {
                    currentPlayCount += count;
                }

                // Update playCount setelah penambahan
                playCount = currentPlayCount.ToString();
            }
            catch (OverflowException)
            {
                // Tangani overflow dengan memberikan pesan error
                Console.WriteLine("Error: Terjadi overflow! Play count melebihi batas maksimum integer.");
            }
        }

        // Method untuk menampilkan detail track
        public void PrintTrackDetails()
        {
            Console.WriteLine("Track Details:");
            Console.WriteLine($"ID         : {id}");
            Console.WriteLine($"Title      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
            Console.WriteLine();
        }
    }
}