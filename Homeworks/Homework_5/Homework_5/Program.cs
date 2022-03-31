using System;
using System.Collections.Generic;

namespace Homework_5
{
    class Program
    {

        static void Main(string[] args)
        {

            Queue<int> queueOfNumbers = MakeAQueue();

            while(queueOfNumbers.Count > 0)
            {
                Console.WriteLine(queueOfNumbers.Dequeue());
            }

        }

        static Queue<int> MakeAQueue()
        {
            Queue<int> queueOfNumbers = new Queue<int>();

            do
            {
                Console.WriteLine("Enter a number to add to the QUEUE!");
                string stringInput = Console.ReadLine();

                if (int.TryParse(stringInput, out int intInput))
                {
                    queueOfNumbers.Enqueue(intInput);
                }
                else
                {
                    Console.WriteLine($"{stringInput} is not a number! Invalid input!");
                }
            } while (InputAgain());

            return queueOfNumbers;
        }

        static bool InputAgain()
        {
            Console.WriteLine("Input 'Y' to enter another number or 'X' to exit!");
            string input = Console.ReadLine();
            
            switch (input.ToLower())
            {
                case "y":
                    return true;

                case "x":
                    return false;
                default:
                    Console.WriteLine("Invalid input!");
                    return InputAgain();
            }
        }
    }
}
