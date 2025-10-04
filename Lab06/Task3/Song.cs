namespace Task3;

public class Song
{
    private string artist;
    private string songName;
    private int minutes;
    private int seconds;

    public string Artist
    {
        get
        {
            return artist;
        }
        private set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException();
            }    
            artist = value;       
        }
    }

    public string SongName
    {
        get
        {
            return songName;
        }
        private set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException();
            }  
            songName = value;       
        }
    }

    public int Minutes
    {
        get
        {
            return minutes;
        }
        private set
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException();
            }
            minutes = value;
        }
    }

    public int Seconds
    {
        get
        {
            return seconds;
        }
        private set
        {
            if (value < 0 || value > 59)
            {
                throw new InvalidSongSecondsException();
            }    
            seconds = value;       
        }
    }

    public int TotalSeconds()
    {
       return Minutes * 60 + Seconds;
    }
    private void ParseAndSetLength(string length)
    {
        string[] parts = length.Split(':');
        if (parts.Length != 2)
        {
            throw new InvalidSongLengthException();
        }

        if (!int.TryParse(parts[0], out int min))
        {
            throw new InvalidSongLengthException();
        }

        if (!int.TryParse(parts[1], out int sec))
        {
            throw new InvalidSongLengthException();
        }    
        Minutes = min;
        Seconds = sec;
    }
    public Song(string artist, string songName, string length)
    {
        Artist = artist;
        SongName = songName;
        ParseAndSetLength(length);   
    } 
}
