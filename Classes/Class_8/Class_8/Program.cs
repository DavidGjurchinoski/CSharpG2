using System;
using System.Collections.Generic;

namespace Class_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary effective no time to search List are slower
            
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>() 
            {
                { "Someone1", 1 },
                { "Someone2", 2 },
                { "Someone3", 3 }

            };

            ageDictionary.Add("David", 23);
            ageDictionary.Add("Else", 99);

            if (ageDictionary.ContainsKey("SDDDA")) Console.WriteLine("It DOES.....");

            ageDictionary["David"] = 33;

            Console.WriteLine($"The age of David is {ageDictionary["David"]}");

            ageDictionary.Remove("dsadselse");



            List<int> intList = new List<int>() { 1, 2, 4 };

            List<string> stringList = new List<string>();

            intList.Add(6);

            Console.WriteLine(intList.Count);

            intList.AddRange(new List<int>(){ 1, 2, 3, 1, 3 });

            Console.WriteLine(intList.IndexOf(3));

            intList.Insert(0, 3);
            
            Console.WriteLine(intList.IndexOf(3));



            Queue<DateTime> dateTimeQueue = new Queue<DateTime>();

            dateTimeQueue.Enqueue(DateTime.Now);
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(5));
            dateTimeQueue.Enqueue(DateTime.Now.AddMonths(2));
            dateTimeQueue.Enqueue(DateTime.Now.AddYears(1));

            Console.WriteLine(dateTimeQueue.Dequeue());
            Console.WriteLine(dateTimeQueue.TryDequeue(out DateTime tryDequeueValue));
            Console.WriteLine(tryDequeueValue);

            DateTime copyDate = dateTimeQueue.Peek();
            dateTimeQueue.TryPeek(out DateTime tryPeekValue);
            Console.WriteLine(tryPeekValue);

            Stack<double> doubleStack = new Stack<double>();

            doubleStack.Push(3.44);
            doubleStack.Push(5.154);
            doubleStack.Push(3.4512);
            doubleStack.Push(3.471114);

            Console.WriteLine(doubleStack.TryPop(out double tryPopValue));
            Console.WriteLine(tryPopValue);


        }
    }
}
