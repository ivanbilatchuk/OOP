using System;
using Task3;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Song[] songs = ReadSongs(n);
        PrintSongs(songs);  
    }
    static Song[] ReadSongs(int n)
    {
        Song[] songs = new Song[n];
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(';');
            try
            {
                if (parts.Length != 3)
                {
                    throw new InvalidSongException();
                }    
                Song song = new Song(parts[0], parts[1], parts[2]);
                songs[count++] = song;
                Console.WriteLine("Song added.");
            }
            catch (InvalidSongException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }    
        Array.Resize(ref songs, count);
        return songs;   
    }

    static void PrintSongs(Song[] songs)
    {
        int totalSec = CalculateTotalSeconds(songs);
        int hours = totalSec / 3600;
        int minutes = (totalSec % 3600) / 60;
        int seconds = totalSec % 60;
        Console.WriteLine($"Songs added: {songs.Length}");
        Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
    }

    static int CalculateTotalSeconds(Song[] songs)
    {
        int totalSec = 0;
        foreach (var s in songs)
        {
            totalSec += s.TotalSeconds();
            
        }    
        return totalSec;   
    }
}