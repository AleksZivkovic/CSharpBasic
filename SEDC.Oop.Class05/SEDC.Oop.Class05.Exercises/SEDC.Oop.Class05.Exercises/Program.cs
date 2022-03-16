using SEDC.Oop.Class05.Exercises.Model;
using System;

namespace SEDC.Oop.Class05.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Kaya";
            dog.Age = 1;



            dog.Talk();


            string message = dog.Talk();
            Console.WriteLine(message);




        }
    }
}
