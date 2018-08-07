using System;
using System.Collections.Generic;
using System.Text;


public class Song
{
    private string artistName;
    private string songName;
    private int hours;
    private int minutes;
    
    public Song(string artistName, string songName, int hours, int minutes)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Hours = hours;
        this.Minutes = minutes;
    }



//•	Song name should be between 3 and 30 symbols.
//•	Song length should be between 0 second and 14 minutes and 59 seconds.
//•	Song minutes should be between 0 and 14.
//•	Song seconds should be between 0 and 59.

    public string ArtistName
    {
        get { return artistName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            artistName = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            songName = value;
        }
    }
    public int Hours
    {
        get { return hours; }
        set { hours = value; }
    }
    
    public int Minutes
    {
        get { return minutes; }
        set { minutes = value; }
    }
        
    
    
    

}

