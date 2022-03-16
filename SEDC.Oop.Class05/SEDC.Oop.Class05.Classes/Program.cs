using SEDC.Oop.Class05.Classes.Models;
using System;

namespace SEDC.Oop.Class05.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Age = 33;
            person.Name = "Trajan";

            person.Talk("Hello world!");

            Person person1 = new Person()
            {
                Age = 22,
                Name = "Vlatko"
            };
          
            person1.Talk("Hello Students!");

            Person person2 = new Person("Bob", 23);
            person2.Talk("Bob is my name");
            
            Console.ReadLine();
        }
    }
}
