using System;
using System.Collections.Generic;

namespace nickleback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();

            HashSet<(string, string)> songs = new HashSet<(string, string)>() { ("Photograph", "Nickleback"),
            ("Far Away", "Nickleback"),
            ("HotelCalifornia", "Eagles"),
            ("Bad Santa", "BucketHead"),
            ("Feelin' Way Too Damn Good", "Nickleback"),
            ("Cemetery Gates", "Pantera"),
            ("For Whom the Bells Toll", "Metallica"),
             };

            foreach ((string, string) song in songs)
            {
                if (song.Item2 != "Nickleback")
                {
                    goodSongs.Add((song.Item1, song.Item2));
                }
            }

            foreach ((string songName, string artist) song in goodSongs)
            {
                Console.WriteLine($"{song.songName} by {song.artist} is a great song!");
            }
        }
    }
}
