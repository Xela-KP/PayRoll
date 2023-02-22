using PayRoll.PayType;
namespace PayRoll.Employees
{
	public class HourlyEmployee: Employee, PaidHourly
	{
		public double Wage { get; set; }
		public HourlyEmployee(string firstName, string lastName, int SIN, double wage) : base(firstName, lastName, SIN)
		{
			Wage = wage;
		}
        public void Pay(double hours)
        {
			if (hours < 40) TotalPaid += Wage * hours;
			else TotalPaid += ( 40 * Wage ) + ( 1.5 * (hours - 40) * Wage );
        }
    }
}

