using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        public int Id;

        public string FirstName;

        public string LastName;

        public DateTime CreateddOn;

        public User(int id, string firstName, string lastName, DateTime createddOn)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CreateddOn = createddOn;
        }
    }
}
