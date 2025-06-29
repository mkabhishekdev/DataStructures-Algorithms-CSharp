using System;

class Program
{
    static void Main(string[] args)
    {
        TYS1_4_MusicPlaylistImpl mpl = new TYS1_4_MusicPlaylistImpl();
        mpl.AddSong("Dream On");
        mpl.AddSong("Olavina Hudugore");
        mpl.AddSong("Strawberry Letter");
        mpl.AddSong("Swades");
        mpl.AddSong("Jaane kya dhoondta hein");
        int playListCount = mpl.PlaylistSize();
        Console.WriteLine("Size of the music playlist is: " + playListCount);
        mpl.DisplayMyPlaylist();
        mpl.DeleteSong("Swades");
        Console.WriteLine("Playlist after deletion of the song is: ");
        mpl.DisplayMyPlaylist();

    }
}




/*
 TYS1_1_BinarySearch bs = new TYS1_1_BinarySearch();
        int[] check = { 2, 5, 9, 11, 17, 21, 44, 50, 62 };

        bs.BinarySearch(check, 99);
*/

/*
 TYS1_3_ReverseSinglyLinkedList rsll = new TYS1_3_ReverseSinglyLinkedList();

        rsll.head = new Node(3);
        rsll.InsertNode(4);
        rsll.InsertNode(5);
        rsll.InsertNode(6);

        rsll.PrintLL();
*/