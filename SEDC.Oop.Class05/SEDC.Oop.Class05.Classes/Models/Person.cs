using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class05.Classes.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        public Person() //Ova e defaul-en konstruktor zatoa sto nema parametri. 
        {
            SSN = GenerateSSN();
        }

        public Person(string name, int age) //string name, int age - se parametri.
        {
            Name = name;
            Age = age;
            SSN = GenerateSSN();
        }
        private long GenerateSSN()
        {
            Random rand = new Random();
            int ssn = rand.Next(100000, 999999);
            return ssn;
        }

        public void Talk(string text)
        {
            Console.WriteLine($"The human named {Name}(SSN:{SSN}) is saying: {text}");
        }

    }
}
