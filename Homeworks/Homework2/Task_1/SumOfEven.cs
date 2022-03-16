using System;

namespace Task_1
{
    class SumOfEven
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = new int[6];
            bool hasNoError = true;
            int sumOfEvenNums = 0;

            for (int counter = 0; counter < arrayOfInts.Length; counter++)
            {
                Console.WriteLine("Enter a number:");

                hasNoError = int.TryParse(Console.ReadLine(), out int numInput);

                if (hasNoError)
                {
                    arrayOfInts[counter] = numInput;
                }
                else
                {
                    Console.WriteLine("Enter only numbers!");
                    counter--;
                }
            }

            foreach (int number in arrayOfInts)
            {
                if (number % 2 == 0)
                {
                    sumOfEvenNums += number;
                }
            }

            Console.WriteLine($"The result is: {sumOfEvenNums}");
        }
    }
    }
}
