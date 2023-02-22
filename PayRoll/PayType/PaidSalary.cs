using System;
namespace PayRoll.PayType
{
	public interface PaidSalary: IPayable
	{
		protected double Salary { get; set; }
		protected void Pay();
	}
}

