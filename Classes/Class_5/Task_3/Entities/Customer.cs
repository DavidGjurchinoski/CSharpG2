using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.Entities
{
    class Customer
    {
        public Customer(string firstName, string lastName, AtmCard card)
        {
            FirstName = firstName;
            LastName = lastName;
            Card = card;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AtmCard Card { get; set; }

        public string PrintFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
