using System;

namespace Class_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = ReadANumber();

            //ShowMsgTwoTimes(number.ToString());

            //for(int counter=0; counter < number; counter++)
            //{
            //    if (IsEvenNumber(number))
            //    {
            //        ShowMsgTwoTimes(counter.ToString());
            //    }
            //}

            //Exercise 1
            Console.WriteLine("Enter an operation + or -");

            string operation = Console.ReadLine();

            int numberOne = EnterAndCheckValidNumber();
            int numberTwo = EnterAndCheckValidNumber();

            Console.WriteLine("Enter Two Numbers:");

            switch (operation) {
                case "+":
                    Console.Write(Sum(numberOne, numberTwo));
                    break;
                case "-":
                    Console.Write(Subtract(numberOne, numberTwo));
                    break;
                default:
                    Console.Write("Invalid Operation expected");
                    break;
            //END Exercise 1
            }
        }

        //static int ReadANumber()
        //{
        //    Console.WriteLine("PLease enter a number:");
        //    bool validInputNum = int.TryParse(Console.ReadLine(), out int inputNum);

        //    if (validInputNum)
        //    {
        //        return inputNum;
        //    }
        //    return -1;
        //}

        //static void ShowMsgTwoTimes(string msg)
        //{
        //    Console.WriteLine(msg);
        //    Console.WriteLine(msg);
        //}

        //static bool IsEvenNumber(int number)
        //{
        //    if(number % 2 == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}


        // Exercise 1
        static int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        static int Subtract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        static int EnterAndCheckValidNumber()
        {
            bool checkValidNum = int.TryParse(Console.ReadLine(), out int number);

            if (!checkValidNum)
            {
                Console.WriteLine("Provided an invalid number, 0 will be outputted");
            }

            return number;
        }
    }
}
