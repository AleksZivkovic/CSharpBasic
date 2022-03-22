using System;

namespace SEDC.Oop.Class02.Homeworks.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            Console.WriteLine("The app name is AverageNumber");

            Console.WriteLine("Please enter the first number!");
            string input1 = Console.ReadLine();
            bool validInteger1 = int.TryParse(input1, out int parsedInput1);

            Console.WriteLine("Please enter the second number!");
            string input2 = Console.ReadLine();
            bool validInteger2 = int.TryParse(input2, out int parsedInput2);

            Console.WriteLine("Please enter the third number!");
            string input3 = Console.ReadLine();
            bool validInteger3 = int.TryParse(input3, out int parsedInput3);

            Console.WriteLine("Please enter the fourth number!");
            string input4 = Console.ReadLine();
            bool validInteger4 = int.TryParse(input4, out int parsedInput4);

            int w = parsedInput1;
            int a = parsedInput2;
            int s = parsedInput3;
            int d = parsedInput4;

            int result = (w + a + s + d) / 4;
            Console.WriteLine(result);
        }

    }
}
