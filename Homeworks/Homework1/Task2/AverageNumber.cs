using System;

namespace Task2
{
    class AverageNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four numbers:");

            //Gets the four inputs of the user and checks if the inputs are numbers and parses them into an 
            //ints if they are, if not outputs an error msg
            if (
            int.TryParse(Console.ReadLine(), out int inputNumOne) &&
            int.TryParse(Console.ReadLine(), out int inputNumTwo) &&
            int.TryParse(Console.ReadLine(), out int inputNumThree) &&
            int.TryParse(Console.ReadLine(), out int inputNumFour) 
                )
            {
                int result = inputNumOne + inputNumTwo + inputNumThree + inputNumFour;
                //Checks if the sum of the inputs is 0(0,0,0,0) or (-1,1,-2,2)... and outputs an error msg if it is
                //if its more then 0 gets the avarage
                if(result == 0)
                { 
                    Console.WriteLine("Error! Cannot calculate average of 0");
                } else
                {
                    Console.WriteLine($"The average of {inputNumOne}, {inputNumTwo}, {inputNumThree} and {inputNumFour} is: {result / 4}");
                }
            } else
            {
                Console.WriteLine("Error! Only enter numbers!");
            }
        }
    }
}
