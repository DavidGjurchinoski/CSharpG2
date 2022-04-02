using Entities;
using Services;
using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<User> users = new List<User>() 
                {
                    new User("Name1", "Last1", "user1", "pass1"),
                    new User("Name2", "Last2", "user2", "pass2"),
                    new User("Name3", "Last3", "user3", "pass3"),
                    new User("Name4", "Last4", "user4", "pass4"),
                    new User("Name5", "Last5", "user5", "pass5"),
                };

                Console.WriteLine("Enter First Name of the user:");
                string firstName = Console.ReadLine();

                if (firstName.Length <= 0) throw new Exception("First Name cant be empty.");

                Console.WriteLine("Enter Last Name of the user:");
                string lastName = Console.ReadLine();

                if (firstName.Length <= 0) throw new Exception("Last Name cant be empty.");

                Console.WriteLine("Enter UserName of the user:");
                string userName = Console.ReadLine();

                if (AuthService.DoesUserNameExist(userName, users)) throw new Exception("Username already exists!");

                Console.WriteLine("Enter UserName of the user:");
                string password = Console.ReadLine();

                if (!AuthService.IsPasswordValid(password)) throw new Exception("Invalid Password!");

                User user = new User(firstName, lastName, userName, password);


            }
            catch (Exception exeption)
            {
                Console.WriteLine(exeption.Message);
            }





        }
    }
}
