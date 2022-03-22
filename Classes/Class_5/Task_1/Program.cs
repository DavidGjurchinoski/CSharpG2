using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredKey = "y";
            do
            {
                if(enteredKey == "y")
                {
                NumberStats(ReadNumber());

                Console.WriteLine("==========================================================================");
                Console.WriteLine("Enter 'y' to try again or x to leave!");
                Console.WriteLine("==========================================================================");
                 enteredKey = Console.ReadLine().ToLower();
                } else if(enteredKey == "x")
                {
                    Console.WriteLine("You have left the app!");
                    break;
                } else
                {
                    Console.WriteLine("You need to enter x or y!");
                }

            }
            while (enteredKey == "y");
        }

        static double ReadNumber()
        {
            Console.WriteLine("Please enter a number");

            string inputValue = Console.ReadLine();

            if (!double.TryParse(inputValue, out double validDouble))
            {
                Console.WriteLine($"The value {inputValue} is not a valid number! Try again!");
                return 0;
            }

            return validDouble;
        }

        static void NumberStats(double number)
        {
            Console.WriteLine(number < 0 ? $"The {number} is negative" : $"The {number} is positive");

            Console.WriteLine(number % 2 == 0 ? $"The {number} is even!" : $"The {number} is odd!");

            Console.WriteLine(number % 1 == 0 ? $"The {number} is an INT!" : $"The {number} is a DECIMAL!");
        }
    }
}
