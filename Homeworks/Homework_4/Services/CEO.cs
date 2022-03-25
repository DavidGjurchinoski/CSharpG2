using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CEO : Employee
    {
        public CEO(string firstName, string lastName, double salary, Employee[] employees, int shares) : base(firstName, lastName, Roles.Other, salary)
        {
            Employees = employees;

            Shares = shares;
        }

        public Employee[] Employees { get; set; }

        public int Shares { get; set; }

        private double SharesPrice { get; set; }

        public void AddSharesPrice(double newSharePrice)
        {
            SharesPrice = newSharePrice;
        }

        public void PrintEmployees()
        {
            foreach(Employee employee in Employees)
            {
                employee.PrintInfo();
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
