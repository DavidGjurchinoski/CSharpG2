using Services;
using System;

namespace Homework_4
{
    class Program
    {
        private static Employee[] company =
        {
            new Contractor("Con1", "LastCon1", 40, 9, new Manager("Manager1", "LastManager1", 3000, "IT")),
            new Contractor("Con2", "LastCon2", 40, 10, new Manager("Manager2", "LastManager2", 2500, "Marketing")),

            new Manager("Manager3", "LastManager3", 2000, "Sales"),
            new Manager("Manager4", "LastManager4", 3000, "IT"),

            new SalesPerson("Sale1", "LastSale1", 1.5)
        };

        static void Main(string[] args)
        {

            CEO ceoNumOne = new CEO("David", "Gjurchinoski", 5000, new Employee[]
            {
                new Employee("Employee1", "LastEmployee1", Roles.Other, 1000),
                new Employee("Employee2", "LastEmployee2", Roles.Other, 1100),
                new Employee("Employee3", "LastEmployee3", Roles.Other, 1200),
            },
            20);

            ceoNumOne.PrintInfo();

            ceoNumOne.PrintEmployees();

            Console.WriteLine($"The salary of the CEO is {ceoNumOne.GetSalary()}");
        }
    }
}
