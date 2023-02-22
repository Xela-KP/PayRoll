using PayRoll.PayType;
namespace PayRoll.Employees
{
    public abstract class Employee: IPayable
    {
        protected string firstName;
        protected string lastName;
        protected int SIN;
        public string Identity {
            get {
                return $"{lastName} {firstName}: {SIN}";
            }
        }
        public double TotalPaid { get; set; }
        public Employee(string firstName, string lastName, int SIN)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.SIN = SIN;
            TotalPaid = 0;
        }
    }
}

