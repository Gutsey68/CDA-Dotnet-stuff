using System;
using System.Globalization;

namespace CDA_Hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AskNumberAndTransform();
            //IsLeapYear();
            WitchIsTheNearest();
        }
        
        private static void AskNumberAndTransform()
        {
            Console.WriteLine("Enter a number:");

            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number < 0)
                    {
                        number = number * -1;
                    }
                    Console.WriteLine("Transformed number: " + number);
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        private static void IsLeapYear()
        {
            Console.WriteLine("Enter a year:");

            while (true)
            {
                try
                {
                    int year = Convert.ToInt32(Console.ReadLine());
                    
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                    {
                        Console.WriteLine("The year " + year + " is a leap year.");
                    }
                    else
                    {
                        Console.WriteLine("The year " + year + " is not a leap year.");
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("Please enter a valid year.");
                }
            }
        }

        private static void WitchIsTheNearest()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number 1:");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter number 2:");
                    int number2 = Convert.ToInt32(Console.ReadLine());
            
                    if (50 - number1 < 50 - number2)
                    {
                        Console.WriteLine("The nearest number to 50 is: " + number1);
                    }
                    else
                    {
                        Console.WriteLine("The nearest number to 50 is: " + number2);
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("You must enter valid numbers, try again !");
                }
            }
        }
    }
}