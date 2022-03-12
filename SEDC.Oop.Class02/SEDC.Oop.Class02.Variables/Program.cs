using System;

namespace SEDC.Oop.Class02.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SEDC!");

            // brojki          
            int number = 3;
            // number = 123456789123546; // cannot put bif number into an 32 bit integer 
            long bigNumber = 123456789123456;
            short shortNumber = 12000;
            byte smallNumber = 8;

            double doublePrecisionNumber = 12.093213;
            float singlePrecisionNumber = 123.1F;

            string str = "Aleksandar Zivkovic";
            char character = 'a';

            bool isSomethingTrue = false;
            DateTime currentDate = new DateTime();

            // var a = 123456789123456;
            // a = 123456789123456,

            //Console.WriteLine("================DATA ENTRY=================");

            //string input = Console.ReadLine();

            //Console.WriteLine("This is the input value: " + input);

            //// int parsedToInteger = int.Parse(input);
            ////Console.WriteLine("This is the paresed input value: " + parsedToInteger);

            ////bool parsedToBoolean = Convert.ToBoolean(input);
            ////int parsedToBoolean = Convert.ToInt32(input);
            ////Console.WriteLine("This is the paresed input value: " + parsedToBoolean);

            //long parsedToLong = 0;
            //bool isValidInput = long.TryParse(input, out parsedToLong);

            //bool isValidInput1 = long.TryParse(input, out long parsedToLong1);

            //Console.WriteLine("Is parsing valid: " + isValidInput);
            //Console.WriteLine("This is the paresed input value: " + parsedToLong);

            //string parsedTolong = parsedToLong.ToString();

            Console.WriteLine("=============================BRANCHING=======================");

            string input = Console.ReadLine();

            bool isValidInteger = int.TryParse(input, out int parsedinput);


            //if(isValidInteger)
            //{
            //    Console.WriteLine("The parsed number is: " + parsedInput);
            //}
            //else
            //{
            //    Console.WriteLine("Not valid input!");
            
            int firstNumber = 5;
            int secondNumber = 10;
            int thirdNumber = 15;
            int fourNumber = 20;

            if(firstNumber < secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("The if statement is TRUE");
            } 
            else if (thirdNumber < fourNumber || secondNumber > fourNumber)
            {
                Console.WriteLine("The first else if statement is TRUE");
            } 
            else if(firstNumber < secondNumber)
            {
                Console.WriteLine("The second else if statement is TRUE");
            } 
            else
            {
                Console.WriteLine("We are in else");
            }





            //Console.ReadLine();
            }
    }
}
