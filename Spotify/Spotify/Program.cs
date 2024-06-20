using System;
using System.Globalization;

namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Spotivy");
            Console.WriteLine("Choose 1 for songs");
            Console.WriteLine("Choose 2 for playlists");
            Console.WriteLine("Choose 3 for albums");
            Console.WriteLine("Choose 4 for friends");
            Console.WriteLine("Choose 5 for artists");
            string choseWhatToDo = Console.ReadLine();

            switch (choseWhatToDo)
            {
                case "1":
                    while (true) { 
                    Song.CreateNewSong();
                        Console.WriteLine("do you want to see all the songs y/n");
                        string seeAllSongs = Console.ReadLine();
                        if (seeAllSongs.ToLower() == "y")
                        {
                           Song.DisplayAllSongs();
                        }
                        Console.WriteLine("do you want to search all songs y/n");
                        String searchForSong = Console.ReadLine();
                        if (searchForSong.ToLower() == "y")
                            
                        {
                        Console.WriteLine("Tiepe 1 to cearch for title ");
                        Console.WriteLine("Tiepe 1 to cearch for artist");
                        Console.WriteLine("Tiepe 1 to cearch for genre ");
                        }
                    }

                    break;
                case "2":
                    /* add song, add album, new playlist, delete song, check playlist */
                    break;
                case "3":
                    /* play album, look at album, select album */
                    break;
                case "4":
                    /* add friend, remove friend, check friend, check friend's playlist, copy friend's playlist */
                    break;
                case "5":
                    /* check artist, check artist's songs, check artist's albums */
                    break;
                default:
                    Console.WriteLine("invalid answer");
                    break;
            }
        }
    }
}
