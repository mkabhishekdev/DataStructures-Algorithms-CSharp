using System.Collections;

public class TYS1_4_MusicPlaylistImpl
{

    public List<string> musicPlaylist = new List<string>();

    public void AddSong(string SongName)
    {
        musicPlaylist.Add(SongName);
    }

    public void DeleteSong(string SongName)
    {
        if (musicPlaylist.Contains(SongName))
        {
            musicPlaylist.Remove(SongName);
        }
        else
        {
            Console.WriteLine("Song not found in the playlist");
        }
    }

    public int PlaylistSize()
    {
        return musicPlaylist.Count;
    }

    public void DisplayMyPlaylist()
    {
        Console.WriteLine("My music playlist is: ");
        for (int i = 0; i < musicPlaylist.Count; i++)
        {
            Console.WriteLine(musicPlaylist[i]);
        }
    }

    public void MoveNextSong()
    {
    
    }

    public void MoveBack()
    {

    }
}