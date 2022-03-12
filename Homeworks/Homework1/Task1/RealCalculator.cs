using System;

namespace Homework1
{
    class RealCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two numbers:");


            //Gets the two inputs of the user and checks if the inputs are numbers and parses them into an 
            //ints if they are, if not outputs an error msg
            if (int.TryParse(Console.ReadLine(), out int inputNumOne) &&
            int.TryParse(Console.ReadLine(), out int inputNumTwo))
            {
                //Goes here if the input is a number
                Console.WriteLine("Enter what operation you want to do with the numbers(+,-,*,/)?");

                //The mathmatical symbol for the operation
                string mathOperationSymbol = Console.ReadLine();
                Console.WriteLine("The result is:");

                //Checking the symbol and doing the accurate operation or displaying an error msg
                switch (mathOperationSymbol)
                {
                    case "+":
                        Console.Write(inputNumOne + inputNumTwo);
                        break;
                    case "-":
                        Console.Write(inputNumOne - inputNumTwo);
                        break;
                    case "*":
                        Console.Write(inputNumOne * inputNumTwo);
                        break;
                    case "/":
                        Console.Write(inputNumOne / inputNumTwo);
                        break;
                    default:
                        Console.WriteLine($"Error! Invalid operator {mathOperationSymbol}!");
                        break;
                }
            }
            else
            {
                //If the input is not a number
                Console.WriteLine("Please enter only NUMBERS!");
            }

        }
    }
}
