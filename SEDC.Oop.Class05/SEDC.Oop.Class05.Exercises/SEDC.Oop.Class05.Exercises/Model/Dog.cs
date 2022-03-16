using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class05.Exercises.Model
{
    public class Dog
    {
        public string Name { get; set; }
        
        public int Age { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Dog()
        {
        }

        public string Talk()
        {
            return ($"The {Name} dog is now eating");
        }
    }
}
