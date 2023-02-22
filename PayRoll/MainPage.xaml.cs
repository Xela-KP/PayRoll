namespace PayRoll;
using Employees;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        SalariedEmployee SEMP = new SalariedEmployee("Hourly", "Employee", 1, 15.0);
		SEMP.Pay();
    }
}


