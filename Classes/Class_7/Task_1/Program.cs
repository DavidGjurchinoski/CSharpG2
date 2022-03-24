using Services;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("David", "Gjurchinoski", Roles.Manager, 1000);

            SalesPerson salePerson = new SalesPerson("Someone", "Else", 2);
        }
    }
}
