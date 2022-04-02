using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public static class AuthService
    {
        public static bool DoesUserNameExist(string userName, List<User> users)
        {
            bool doesExist = false;

            users.ForEach(user =>
            {
                if (user.Username == userName) doesExist = true;
            });

            return doesExist;
        }

        public static User LogIn(User inputUser, List<User> users)
        {
            User user = null;

            users.ForEach(entry =>
            {
                if (entry.Username == inputUser.Username && entry.Password == inputUser.Password)
                {
                    user = entry;
                }
            });

            return user;
        }

        public static bool IsPasswordValid(string password)
        {
            if (password.Length < 8) return false;

            bool hasUpperChar = false;
            bool hasNumberChar = false;
            bool hasLowerChar = false;

            foreach (char symbol in password)
            {

                if (Char.IsLower(symbol)) hasLowerChar = true;

                if (Char.IsUpper(symbol)) hasUpperChar = true;

                if (Char.IsNumber(symbol)) hasNumberChar = true;

                if (hasLowerChar && hasUpperChar && hasNumberChar) return true;

            }

            return false;
        }

        //public static List<User> RegisterUser(User inputUser, List<User> users)
        //{
        //    if (DoesUserNameExist(inputUser.Username, users))
        //    {
        //        Console.WriteLine($"The user: {inputUser.Username} already exists!");

        //        return users;
        //    }

        //    if (IsUserNameValid(inputUser.Username))
        //    {
        //        users.Add(inputUser);

        //        Console.WriteLine($"The user: {inputUser.Username} has been created!");

        //        return users;
        //    }
        //    else Console.WriteLine($"This: {inputUser.Username} is not a valid UserName(Enter at least 8 cahrs, at lest one Upper, one lower and one number)");

        //    return users;
        //}

        //public static List<User> RemoveUser(string userName, List<User> users)
        //{
        //    try
        //    {
        //    users.Remove(users.Single<User>(entry => entry.Username == userName));
        //    }
        //    catch(Exception exeption)
        //    {
        //        Console.WriteLine(exeption.Message);
        //    }

        //    return users;
        //}
    }
}
