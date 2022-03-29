using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
            static Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                { "Name1", "075673634" },
                { "Name2", "078073634" },
                { "Name3", "075973634" },
                { "Name4", "075670876" },
                { "Name5", "075670875" }
            };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name and a phone number");

            Console.WriteLine("enter a name to see the phone number:");
            string userInput = Console.ReadLine();

            if (phoneBook.ContainsKey(userInput))
            {
                Console.WriteLine($"The phone number of {userInput} is {phoneBook[userInput]}.");
            } else
            {
                Console.WriteLine($"The name {userInput} does not exist in the phonebook!");
            }

        }

        static void AddToPhoneBook(string name, string phoneNumber)
        {
            if(phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"The name {name} is already listed.");
                return;
            }

            phoneBook.Add(name, phoneNumber);
        }
    }
}
