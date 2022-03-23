using System;

namespace SEDC.Oop.Class02.exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //======================exercise 1=================================== 
            //double first = 100.1;
            //double second = 50.1;
            //double result = first / second;            

            //int first1 = 100;
            //int second2 = 50;
            //int result1 = first1 / second2;

            ////Console.WriteLine("This is the reslut: " + result);
            ////Console.WriteLine("This is the reslut1: " + result1);
            ////Console.WriteLine("Are they equal?");
            ////Console.WriteLine(result == result1);


            //======================exercise 2===================================
            //string firstName = "Aleksandar ";
            //string secondName = "Zivkovic";
            //string fullName = firstName + secondName;
            //string firstNumebr = "9";
            //string secondNumber = "3";
            //string firstAndSecondNumber = firstNumebr + secondNumber;
            //Console.WriteLine(fullName);
            //Console.WriteLine(firstAndSecondNumber);


            //======================exercise 3===================================
            //int age = 35;
            //string fullName = "Aleksandar Zivkovic";


            //======================exercise 4===================================
            //int N = 102;
            //int M = 5;
            //int result = 102 / 5;
            //Console.WriteLine(result);


            //======================exercise 5===================================
           
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            bool isValidInteger = int.TryParse(input, out int parsedInput);

            if (isValidInteger)
            {
                Console.WriteLine("The number is valid!");
                int N = 8;
                int M = 5;

                int result = parsedInput * N / M;
                Console.WriteLine("You will need " + result + " baskets!");
            }            
            else  
            {
                Console.WriteLine("Nice try :)");
                Console.WriteLine("Please enter a valid number!");
            }
            

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
            //Console.WriteLine("Select from the following numbers:");
            //Console.WriteLine("1.Input  for a new car");
            //Console.WriteLine("2.Input  for a new plane");
            //Console.WriteLine("3.Input  for a new bike");

            //string inputFrom = Console.ReadLine();
            //bool parsedInputFromConsole = int.TryParse(inputFrom, out int parsedInput);
            //switch (parsedInput)
            //{
            //    case 1:
            //        Console.WriteLine("You got a new car");
            //        break;
            //    case 2:
            //        Console.WriteLine("You got a new plane");
            //        break;
            //    case 3:
            //        Console.WriteLine("You got a new bike");
            //        break;
            //    default:
            //        Console.WriteLine("Input a correct number");
            //        break;
            //}
        }
    }
}