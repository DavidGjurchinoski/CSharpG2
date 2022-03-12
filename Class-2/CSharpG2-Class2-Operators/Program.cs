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

            Console.WriteLine("Enter number of credits:");
            string numberOfCreditsString = Console.ReadLine();
            Console.WriteLine("Enter cost of 1 SMS:");
            string costOfSMSString = Console.ReadLine();

            int numberOfCreditsInt = int.Parse(numberOfCreditsString);
            int costOfSMSInt = int.Parse(costOfSMSString);

            int numberOfSMSSends = numberOfCreditsInt / costOfSMSInt;

            Console.WriteLine($"You can send {numberOfSMSSends} SMS with this amount of credits {numberOfCreditsString}");

            Console.WriteLine("Enter Two Numbers:");
            string inputNumOne = Console.ReadLine();
            string inputNumTwo = Console.ReadLine();

            int.TryParse(inputNumOne, out int inputNumOneInt);
            int.TryParse(inputNumTwo, out int inputNumTwoInt);
            string biggerNumber;
            if (inputNumOneInt != inputNumTwoInt)
            {
                biggerNumber = (inputNumOneInt > inputNumTwoInt) ? inputNumOne : inputNumTwo;
            }
            else
            {
                biggerNumber = "The nums are The same";
            }

            Console.WriteLine($"The number {biggerNumber} is bigger");
            Console.WriteLine("The input one is ");
            Console.Write((inputNumOneInt % 2) == 0 ? "Even" : "Odd");
            Console.WriteLine("The input two is ");
            Console.Write((inputNumTwoInt % 2) == 0 ? "Even" : "Odd");


            //Exe 6 Home

            Console.WriteLine("Enter a number between 1 to 3");
            string input = Console.ReadLine();
            if (
            int.TryParse(input, out int inputToInt) && (inputToInt <= 1) && (inputToInt >= 3)
               )
            {
                switch (inputToInt)
                {
                    case 1:
                        {
                            Console.WriteLine("You got a NEW HOUSE");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("You got a NEW CAR");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("You got a NEW SOMETHING ELSE");
                            break;
                        }
                }
            }
        }
    }
}
