using System;

namespace SEDC.Oop.Class02.Homeworks.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables
            //so that the first variable has the second value and the second variable the first value. 

            Console.WriteLine("The app name is SwapNumbers");

            Console.WriteLine("Please enter first number!");
            string input1 = Console.ReadLine();
            bool isValidInteger1 = int.TryParse(input1, out int parsedInput1);

            Console.WriteLine("Please enter second number!");
            string input2 = Console.ReadLine();
            bool isValidInteger2 = int.TryParse(input2, out int parsedInput2);

            int x = parsedInput1;
            int y = parsedInput2;

            Console.WriteLine("Before swap x= " + x + " y= " + y);
            x = x * y;
            y = x / y;
            x = x / y;

            Console.WriteLine("After swap x= " + x + " y= " + y);



        }
    }
}
