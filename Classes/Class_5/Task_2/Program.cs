using System;
using Task_2.Entities;

namespace Task_2
{
    class Program
    {
        static User[] listOfUsers;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter L or R to log in or register!");

            switch(Console.ReadLine().ToLower())
            {
                case "l":
                    LogIn(listOfUsers);
                    break;
                case "r":
                    RegisterUser(listOfUsers);
                    break;
                default:
                    Console.Write("Invalid input!");
                    break;
            }
        }

        static void LogIn(User[] users)
        {
            //Validacija na inputs da se vrshi edno po endo buznis logic

            Console.WriteLine("Please enter a Username");
            string inputUserName = Console.ReadLine();

            Console.WriteLine("Please enter a Password");
            string inputPassword = Console.ReadLine();

            User user = FindUser(inputUserName, inputPassword, listOfUsers);

            if (user != null)
            {
                Console.WriteLine($"Welcome {user.UserName}. Your Messages:");
                user.PrintsMsgs();
            } else { 
                Console.WriteLine("No user found invalid inputs");
            }
        }

        private static User FindUser(string username, string password, User[] users)
        {
            foreach (User user in users)
            {
                if (user.UserName == username && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        static void RegisterUser(User[] users)
        {
            Console.WriteLine("Please enter a Id");
            string inputId = Console.ReadLine();

            Console.WriteLine("Please enter a Username");
            string inputUserName = Console.ReadLine();

            Console.WriteLine("Please enter a Password");
            string inputPassword = Console.ReadLine();

            User user = FindUser(inputUserName, inputPassword, listOfUsers);

            if(user == null)
            {
            if (
                //int.TryParse(inputId, out int validId) && inputUserName.Length > 0 && inputPassword.Length > 0
                int.TryParse(inputId, out int validId) &&
                !string.IsNullOrEmpty(inputUserName) &&
                !string.IsNullOrEmpty(inputPassword)
                )
            {
                listOfUsers[^1] = new User(validId, inputUserName, inputPassword, new string[] { "Something1", "Something2", "Something3" });
                Array.Resize<User>(ref listOfUsers, listOfUsers.Length + 1);

                foreach(User newUser in users)
                    {
                        Console.WriteLine(newUser.Id + " " + newUser.UserName);
                    }
            }
            } else
            {
                Console.WriteLine("Invalid inputs!");
            }
        }
    }
}
