using System;
namespace PayRoll.PayType
{
	public interface PaidHourly: IPayable
	{
		protected double Wage { get; set; }
		protected void Pay(double hours);
	}
}

