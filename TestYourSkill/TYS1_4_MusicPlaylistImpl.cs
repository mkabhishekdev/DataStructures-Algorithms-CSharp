using System.Collections;

/* Using doubly linked list - you can enable both next and prev songs
in the playlist feature
*/

public class TYS1_4_MusicPlaylistImpl
{

    public class Node
    {
        public string songName { get; set; }
        public Node next;
        public Node prev;
        public Node(string x)
        {
            songName = x;
            next = null;
            prev = null;
        }
    }


    public Node headSong = null;


    public void AddSong(string SongName)
    {
        Node songToAdd = new Node(SongName);

        if (headSong == null)
        {
            headSong = songToAdd;
        }
        else
        {
            Node curr = headSong;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = songToAdd;
            songToAdd.prev = curr;
            songToAdd.next = null;
        }
        Console.WriteLine("Song added");
    }


    public void DeleteSong(string SongName)
    {
        if (headSong == null)
        {
            return;
        }
        Node curr = headSong;

        while (curr != null)
        {
            if (curr.songName == SongName)
            {
                if (curr.prev != null)
                {
                    curr.prev.next = curr.next;
                }
                else
                {
                    headSong = curr.next;
                }
                if (curr.next != null)
                {
                    curr.next.prev = curr.prev;
                }
                Console.WriteLine("Song has been deleted");
                return;
            }
            curr = curr.next;
        }

        Console.WriteLine("Song not found");
    }


    public void PlayNext(string presentSong)
    {
     
    }


    public void PlayPrevious(string presentSong)
    {
      

    }

    public int PlaylistSize()
    {
        Node curr = headSong;
        int count = 0;

        while (curr != null)
        {
            curr = curr.next;
            count++;
        }

        Console.WriteLine("The number of songs in the playlist is: " + count);
        return count;
    }

    public void DisplayMyPlaylist()
    {
        Node curr = headSong;

        Console.WriteLine("Songs in the Playlist are: ");
        while (curr != null)
        {
            Console.WriteLine(curr.songName);
            curr = curr.next;
        }

    }

}






































/*
WRONG DESIGN THOUGHT - SHOULD USE 'LINKED LIST'
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
    */