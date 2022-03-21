using System;

namespace SEDC.Oop.Class06.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberStats(5.5);
            Console.WriteLine("Please enter a number:");
            //double num = Console.ReadLine();
        }
        public static void NumberStats(double num)
        {                            

            if (num < 0)
            {
                Console.WriteLine("The number is NEGATIVE"); 
            }
            if (num > 0)
            {
                Console.WriteLine("The number is POSITIVE");
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is EVEN");
            }
            else 
            {
                Console.WriteLine("The number is ODD");
            }
            if (num % 1 > 0)
            {
                Console.WriteLine("The number is DECIMAL");
            }
            else
            {
                Console.WriteLine("The number is INTEGER");
            }
            

            
        }

        

       
        

    }
}
