using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.Exercise2
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Genre FavouriteMusicType { get; set; }

        public List<Song> FavouriteSongs { get; set; }

        public void GetFavSongs()
        {
            if (FavouriteSongs == null || FavouriteSongs.Count == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                foreach (Song song in FavouriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
            
        }
    }
}
