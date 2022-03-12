using System;

namespace Task3
{
    class SwapNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers!");

            //Gets the two inputs of the user and checks if the inputs are numbers and parses them into an 
            //ints if they are, if not outputs an error msg
            if (int.TryParse(Console.ReadLine(), out int inputNumOne) &&
            int.TryParse(Console.ReadLine(), out int inputNumTwo))
            {
                //Preforming a swap of two vars without a helper var
                //Hold both values in one var with "+"
                //Then the second var will be the first value - the second value so it gets the first variables value
                //Then by "-" the first variable with the new second variable wich is the first(at this point) we get the second value in the first var
                inputNumOne = inputNumOne + inputNumTwo;
                inputNumTwo = inputNumOne - inputNumTwo;
                inputNumOne = inputNumOne - inputNumTwo;

                //Output the swaped variables
                Console.WriteLine("After swaping:");
                Console.WriteLine($"First Number: {inputNumOne}");
                Console.WriteLine($"Second Number: {inputNumTwo}");
            } else
            {
                Console.WriteLine("Enter only numbers!");
            }

        }
    }
}
