namespace PayRoll.PayType
{
	public interface PaidCommission: IPayable
	{
		protected double CommissionRate { get; set; }
		protected void Pay(int sales);
	}
}

