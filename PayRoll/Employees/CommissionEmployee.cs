using PayRoll.PayType;
namespace PayRoll.Employees
{
	public class CommissionEmployee: Employee, PaidCommission
	{
        public double CommissionRate { get; set; }
		public CommissionEmployee(string firstName, string lastName, int SIN, double commissionRate): base(firstName, lastName, SIN)
		{
            CommissionRate = commissionRate;
		}

        public void Pay(int sales)
        {
            TotalPaid += sales * CommissionRate;
        }
    }
}

