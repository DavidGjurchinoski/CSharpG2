using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstString = "Hallo" + "You";
            //int classNumber = 4;
            //No diff between the lower 2
            //string secondString = $"The Variable classNumber is value: {classNumber}";
            //string thirdString = string.Format("Paramater entered {0}. Second variable scondString value: {1}", 34, secondString);

            //StringBuilder sb = new StringBuilder();

            //sb.Append("test").Append("test").Append("teest");

            //Console.WriteLine("c:\\drive");
            //Console.WriteLine("We will have \"fair\" elections!");
            //Console.WriteLine("the \\n symbol means new line");

            //Console.WriteLine(@"c:\drive We will have ""fair"" elections! the \n symbol means new line");

            //decimal decimalNumber = 3.43535m;
            //Console.WriteLine(string.Format("{0:N2}", decimalNumber));

            //decimal price = 9.99m;
            //Console.WriteLine($"The price is: {price}$");
            //Console.WriteLine(string.Format("{0:C}", price));

            //decimal discount = 0.5m;
            //Console.WriteLine(string.Format("{0:P}", discount));

            //Console.WriteLine(string.Format("{0:###-###-###}", 078894890));

            //string text = "         THIS IS A C# class UPPER and lower TEXT!        ";
            //Console.WriteLine(text.ToLower());
            //Console.WriteLine(text.ToUpper());
            //Console.Write(text);
            //Console.Write("THERE IS WHITE SPACES!");

            //Console.WriteLine();

            //Console.Write(text.Trim());
            //Console.Write("THERE IS NO WHITE SPACES!");

            //bool doesStartWith = text.ToLower().StartsWith("this");

            //int indexOfIS = text.ToLower().IndexOf("is");

            //string subString = text.Substring(text.ToLower().IndexOf("is"), 2);


            //string[] words = text.Split(' ');
            //foreach(string word in words)
            //{
            //    Console.WriteLine(word);
            //}

            Substring("Normal $*(@!$(*@!$&(*@!&$");
            Substring("");

        }

        static void Substring(string text)
        {
            if (text.Length != 0)
            {
            Console.WriteLine("Enter a number:");

            bool isValidNum = int.TryParse(Console.ReadLine(), out int inputNum);
            if(!isValidNum)
                {
                    Console.WriteLine("Enter a number PLEASE!");
                    return;
                }

            if(text.Length < inputNum)
                {
                    Console.WriteLine("Input number biiger the number of chars in the text!");
                    return;
                }

                string newSubstring = text.Substring(inputNum, text.Length - inputNum);

            Console.WriteLine($"The string {newSubstring} after the index {inputNum}, the length of the new string is {newSubstring.Length}");
            }
            else
            {
            Console.WriteLine("AN Error with the input text occured!");
            return;
            }
        }
    }
}
