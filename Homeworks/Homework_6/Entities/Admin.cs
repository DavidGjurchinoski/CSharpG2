using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Admin : User
    {
        public Admin(string firstName, string lastName, string usernama, string password) : base(firstName, lastName, usernama, password)
        {
        }

        public List<User> AddUser(User inputUser, List<User> users)
        {

            users.Add(inputUser);

            return users;

        }
        public static List<User> RemoveUser(string userName, List<User> users)
        {
            users.Remove(users.Single<User>(entry => entry.Username == userName));

            return users;
        }
    }
}
