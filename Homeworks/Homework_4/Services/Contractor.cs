

namespace Services
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }

        public int PayPerHour { get; set; }

        public Manager Responsible { get; set; }

        //0 for salary because we set it with the method GetSalary()
        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager manager) : base(firstName, lastName, Roles.Other, 0)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = manager;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;

            return Salary;
        }

        public string CurrentPosition()
        {
            return Responsible.Department;
        }
    }
}
