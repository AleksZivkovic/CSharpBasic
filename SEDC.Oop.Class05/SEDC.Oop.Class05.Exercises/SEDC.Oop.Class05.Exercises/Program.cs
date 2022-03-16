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



            Dog.Talk("The dog is now eating");



            Console.ReadLine();




        }
    }
}
