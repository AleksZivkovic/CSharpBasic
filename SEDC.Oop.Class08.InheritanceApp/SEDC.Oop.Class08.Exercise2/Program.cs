using System;

namespace SEDC.Oop.Class08.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Id = 35,
                FirstName = "Aleksandar",
                LastName = "Zivkovic",
            };
            Console.WriteLine(person.FirstName + person.LastName + person.Id);
            person.GetFavSongs();
        }
    }
}
