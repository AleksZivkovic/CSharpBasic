using System;

namespace SEDC.Oop.Class02.Homeworks.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Create new console application “RealCalculator” that takes two numbers from the input and
            //asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.

            Console.WriteLine("The app name is RealCalculator");

            Console.WriteLine("Please enter first number!");
            string input1 = Console.ReadLine();
            bool valindInteger1 = int.TryParse(input1, out int parsedInput1);

            Console.WriteLine("Please enter second number!");
            string input2 = Console.ReadLine();
            bool valindInteger2 = int.TryParse(input2, out int parsedInput2);

            char opertaion;
            Console.WriteLine("Please enter Operation. Example +, -, *, /");
            opertaion = Convert.ToChar(Console.ReadLine());

            if (opertaion == '+')
            {
                int x = parsedInput1;
                int y = parsedInput2;
                int result = x + y;
                Console.WriteLine(result);
            }
            else if (opertaion == '-')
            {
                int x = parsedInput1;
                int y = parsedInput2;
                int result = x - y;
                Console.WriteLine(result);
            }
            else if (opertaion == '*')
            {
                int x = parsedInput1;
                int y = parsedInput2;
                int result = x * y;
                Console.WriteLine(result);
            }
            else if (opertaion == '/')
            {
                int x = parsedInput1;
                int y = parsedInput2;
                int result = x / y;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter a valid Opertation!");
            }
        }
    }
}
