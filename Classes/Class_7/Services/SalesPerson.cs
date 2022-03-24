
namespace Services
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenu;

        public SalesPerson(string firstName, string lastName, double successFactor) : base(firstName, lastName, Roles.Sales, 500)
        {
            _successSaleRevenu = successFactor;
        }

        public void AddSuccessRevenu(double newSuccessRevenu)
        {
            _successSaleRevenu = newSuccessRevenu;
        }

        public override double GetSalary()
        {
            if (_successSaleRevenu <= 2000)
            {
                return base.GetSalary() + 500;
            }

            if (_successSaleRevenu > 2000 && _successSaleRevenu <= 5000)
            {
                return base.GetSalary() + 1000;
            }

            return base.GetSalary() + 1500;
        }
    }
}
