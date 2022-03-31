using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{

    class Program
    {

                static Dictionary<int, User> listOfUsers = new Dictionary<int, User>() 
                {
                    { 1, new User(1, "Name1", "LastName1", new DateTime()) },
                    { 2, new User(2, "Name2", "LastName2", new DateTime()) },
                    { 3, new User(3, "Name3", "LastName3", new DateTime()) },
                    { 4, new User(4, "Name4", "LastName4", new DateTime()) },
                };

        static void Main(string[] args)
        {
            RegisterNewUser();

            SearchUsers();
        }

        static void RegisterNewUser()
        {
            try
            {
                Console.WriteLine("Enter your id");
                string stringId = Console.ReadLine();

                if (stringId.Length == 0)
                {
                    throw new Exception("Cant input with no id!");
                }

                if (!int.TryParse(stringId, out int intId))
                {
                    throw new Exception("Enter only numbers!");
                }

                Console.WriteLine("Enter your First Name");
                string stringFirstName = Console.ReadLine();

                if (stringFirstName.Length == 0)
                {
                    throw new Exception("Cant input with no name!");
                }

                Console.WriteLine("Enter your Last Name");
                string stringLastName = Console.ReadLine();

                if (stringLastName.Length == 0)
                {
                    throw new Exception("Cant input with no last name!");
                }

                listOfUsers.Add(intId, new User(intId, stringFirstName, stringLastName, new DateTime()));
            }
            catch (Exception exeption)
            {
                Console.WriteLine(exeption.Message);
                RegisterNewUser();
            }
        }

        static void SearchUsers()
        {
            Console.WriteLine("Enter First Name or Last Name or Id to search by!");
            string searchString = Console.ReadLine();

            List<User> users = listOfUsers
                .Values
                .Where(x => x.FirstName == searchString || x.LastName == searchString || x.Id.ToString() == searchString)
                .ToList();

            if (users.Any())
            {
                users
                    .ForEach(user =>
                    {
                        Console.WriteLine($"Name: {user.FirstName}, Last Name: {user.LastName}, Id: {user.Id}");
                    });
            }
            else
            {
                Console.WriteLine("There are no users with that search input!");
            }

        }
    }
}
