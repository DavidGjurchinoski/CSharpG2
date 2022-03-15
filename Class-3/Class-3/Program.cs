using System;

namespace Class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number:");

            //string inputStringOne = Console.ReadLine();
            //int.TryParse(inputStringOne, out int inputIntOne);

            //for(int counter = 2; counter <= inputIntOne; counter += 2)
            //{
            //    Console.WriteLine(counter);
            //}

            //string inputStringTwo = Console.ReadLine();
            //int.TryParse(inputStringTwo, out int inputIntTwo);

            //for (int counter = 1; counter <= inputIntTwo; counter += 2)
            //{
            //    Console.WriteLine(counter);
            //}

            //Console.WriteLine("Enter a number");

            //string inputStringOne = Console.ReadLine();

            //bool isInputNumber = int.TryParse(inputStringOne, out int inputIntOne);

            //if(isInputNumber)
            //{
            //    for (int counter = 1; counter <= inputIntOne; counter++)
            //    {
            //        if ((counter % 3 == 0) || (counter % 7 == 0))
            //        {
            //            continue;
            //        }
            //        if (counter >= 100)
            //        {
            //            Console.WriteLine("The limet is reached!");
            //            break;
            //        }
            //        Console.WriteLine(counter);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter only numbers!");
            //}

            //int[] intArray = new int[2];

            //intArray[1] = 3;

            //int indexOfSOmething = Array.IndexOf(intArray, 3);

            //Console.WriteLine(indexOfSOmething);

            //Array.Resize(ref intArray, 7);

            //intArray[6] = 10;

            //foreach(int number in intArray)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] stringArray = new string[] { "name1", "name2", "name3", "name4", "name5" };

            //int[] intArray = new int[] { 1,2,3,4,5 };

            //double[] decimalArray = new double[] { 1.2, 3.4, 5.6, 7.9, 0.7 };

            //New C# Matri syntax
            //int[,] intMatrix = new int[5, 5];


            int[] intArray = new int[5];
            bool isValidNum = false;

            Console.WriteLine("Enter 5 numbers:");

            for (int counter = 0; counter < 5; counter++)
            {
                isValidNum = int.TryParse(Console.ReadLine(), out int inputNum);
                if (isValidNum)
                {
                    intArray[counter] = inputNum;
                }
                else
                {
                    Console.WriteLine("Enter only numbers!");
                    break;
                }
            }
            
            if (isValidNum)
            {
                int sum = 0;
                foreach (int num in intArray)
                {
                    sum += num;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
