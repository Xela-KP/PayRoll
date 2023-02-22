using System;
namespace PayRoll.Employees
{
    public static class Repository
    {
        public static List<Employee> Employees = new List<Employee>
        {
            //new SalariedEmployee(),
            new HourlyEmployee("Hourly", "Employee", 1, 15.0),
            //new CommissionEmployee(),
            //new SalariedCommissionEmployee()
        };

        public static string GetAllEmployees()
        {
            string employees = "";
            foreach(Employee employee in Employees)
            {
                employees += $"{employee.Identity}\n";
            }
            return employees;
        }
    }

}

