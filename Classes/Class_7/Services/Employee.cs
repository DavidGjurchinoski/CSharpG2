using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Roles Role { get; set; }

        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, Roles role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} has a salary of {Salary}$");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
