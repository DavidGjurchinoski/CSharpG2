using Entities;
using System;
using System.Collections.Generic;

namespace Task_2
{

    class Program
    {
        static void Main(string[] args)
        {
                new Dictionary<int, User>() 
                {
                    { 1, new User(1, "Name1", "LastName1", new DateTime()) },
                    { 2, new User(2, "Name2", "LastName2", new DateTime()) },
                    { 3, new User(3, "Name3", "LastName3", new DateTime()) },
                    { 4, new User(4, "Name4", "LastName4", new DateTime()) },
                };
        }

        static void RegisterNewUser()
        {
            Console.WriteLine("Enter your id");
            string stringId = Console.ReadLine();

            if(stringId.Length == 0 || !int.TryParse(stringId, out int intId))
            {
                Console.WriteLine("Invalid Input!");
            }

            Console.WriteLine("Enter your First Name");
            string stringFirstName = Console.ReadLine();

            if (stringFirstName.Length == 0)
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
