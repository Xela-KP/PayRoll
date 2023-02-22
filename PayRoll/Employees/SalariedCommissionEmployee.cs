using PayRoll.PayType;
namespace PayRoll.Employees
{
	public class SalariedCommissionEmployee: CommissionEmployee, PaidSalary
	{
        public double Salary { get; set; }
        public SalariedCommissionEmployee(string firstName, string lastName, int SIN, double commissionRate)
            : base(firstName, lastName, SIN, commissionRate)
        {
            Salary = 0;
        }
        public new void Pay(int sales)
        {
            base.Pay(sales);
            Pay();
        }
        public void Pay()
        {
            TotalPaid += Salary;
        }
	}
}

