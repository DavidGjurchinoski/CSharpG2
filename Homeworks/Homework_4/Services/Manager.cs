using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string firstName, string lastName, double salary, string department) : base(firstName, lastName, Roles.Manager, salary)
        {
            Department = department;
        }
    }
}
