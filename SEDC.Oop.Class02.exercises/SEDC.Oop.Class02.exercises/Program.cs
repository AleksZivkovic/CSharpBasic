using System;

namespace SEDC.Oop.Class02.exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Stefan fatal error 
            //int n = 102;
            //int m = 5;

            //int result = n / m;
            //Console.WriteLine(result);

            //======================exercise 6===================================
            //string firstvariable = Console.ReadLine();
            //string secondvariable = Console.ReadLine();

            //bool firstvariableParst = int.TryParse(firstvariable, out int parsedInput1);
            //bool secondtvariableParst = int.TryParse(secondvariable, out int parsedInput2);

            //if (parsedInput1 > parsedInput2)
            //{
            //    Console.WriteLine(parsedInput1 + " " + "Firs number is biger");
            //}
            //else if (parsedInput1 < parsedInput2)
            //{
            //    Console.WriteLine(parsedInput2 + " " + "Second number is biger");
            //}

            //if (parsedInput1 % 2 == 0 && parsedInput2 % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");

            //}

            //======================exercise 7===================================

            Console.WriteLine("Select from the following numbers:");
            Console.WriteLine("1.Input  for a new car");
            Console.WriteLine("2.Input  for a new plane");
            Console.WriteLine("3.Input  for a new bike");

            string inputFrom = Console.ReadLine();
            bool parsedInputFromConsole = int.TryParse(inputFrom, out int parsedInput);
            switch (parsedInput)
            {
                case 1:
                    Console.WriteLine("You got a new car");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike");
                    break;
                default:
                    Console.WriteLine("Input a correct number");
                    break;











            }
        }
    }
}