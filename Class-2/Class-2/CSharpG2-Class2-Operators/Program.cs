using System;

namespace CSharpG2_Class2_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            double doubleOne;
            double doubleTwo;

            doubleOne = 2.13132133121;
            doubleTwo = 2;
            double resultDouble = doubleOne / doubleTwo;

            int intOne;
            int intTwo;

            intOne = 1;
            intTwo = 2;

            int resultInt = intOne / intTwo;

            Console.WriteLine("compare values: \n Result Int = " + resultInt + " Result Double = " + resultDouble);
            Console.WriteLine("Rounded Result Double " + Math.Round(resultDouble, 2));
            Console.WriteLine("Rounded Result Double " + String.Format("{0:0.00}", resultDouble));

            Console.WriteLine("================================================================================");

            string stringOne;
            string stringTwo;

            stringOne = "String Num One";
            stringTwo = "String Num Two";
            string resultString = stringOne + " " + stringTwo;

            string stringThree;
            string stringFour;

            stringThree = "9";
            stringFour = "3";
            string stringNumResult = stringThree + stringFour;

            Console.WriteLine($"{stringNumResult}\n{resultString}");

            //Exe 3,4 HomeWork

        }
    }
}
