using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Entities
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string[] Massages { get; set; }
 
        public User(int id, string userName, string password, string[] massages)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Massages = massages;
        }

        public void PrintsMsgs()
        {
            foreach (string msg in Massages)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
