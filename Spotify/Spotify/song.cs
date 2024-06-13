using System;
using System.Collections.Generic;

namespace Spotivy
{
    public class Song
    {
        public string Title { get; set; }
        public string Artists { get; set; }
        public string Genre { get; set; }


        private static List<Song> allSongs = new List<Song>();

        public Song(string title, string artists, string genre)
        {
            Title = title;
            Artists = artists;
            Genre = genre;
        }

        public static void CreateNewSong()
        {
            Console.WriteLine("Enter song title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter song artists:");
            string artists = Console.ReadLine();

            Console.WriteLine("Enter genre:");
            string genre = Console.ReadLine();

            Song newSong = new Song(title, artists, genre);
            allSongs.Add(newSong);

            Console.WriteLine("New song created:");
            Console.WriteLine($"Title: {title}, Artists: {artists}, Genre: {genre}");
        }

        public static void DisplayAllSongs()
        {
            Console.WriteLine("All Songs:");
            foreach (var song in allSongs)
            {
                Console.WriteLine($"Title: {song.Title}, Artists: {song.Artists}, Genre: {song.Genre}");
            }
        }
    }
}
