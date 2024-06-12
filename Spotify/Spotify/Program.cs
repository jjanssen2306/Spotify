using System.Globalization;namespace Spotify{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Spotify");
            Console.WriteLine("choose 1 for songs");
            Console.WriteLine("choose 2 for playlists");
            Console.WriteLine("choose 3 for albums");
            Console.WriteLine("choose 4 for friends");
            Console.WriteLine("choose 5 for artists");
            string choseWhatToDo = Console.ReadLine();

            switch (choseWhatToDo)
            {
                case "1":
                    /* play song, look at song, select song */
                    break;
                case "2":
                    /* add song, add album, new playlist, delete song, check playlist*/
                    break;
                case "3":
                    /* play album, look at album, select album */
                    break;
                case "4":
                    // add friend, remove friend, check friend, check friend's playlist, copy friend's playlist
                    break;
                case "5":
                    /* check artist, check artist's songs, check artist's albums*/
                    break;
                default:
                    /*invaled answer*/
                    break;
            }
        }
    }
}
