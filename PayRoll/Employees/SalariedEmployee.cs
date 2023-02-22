using PayRoll.PayType;

namespace PayRoll.Employees
{
    public class SalariedEmployee : Employee, PaidSalary
    {
        public double Salary { get; set; }
        public SalariedEmployee(string firstName, string lastName, int SIN) : base(firstName, lastName, SIN)
        {
            Salary = 0;
        }

    }
}
