using BilgeAdam.HR.Common.Abstractions;

namespace BilgeAdam.HR.Common.Models
{
    public class Employee : Person, IPermanentEmployee
    {
        private Person reportsTo;
        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Person ReportsTo { get { return reportsTo; } }

        public decimal Salary { get; set; }

        public void SetManager(IManager manager)
        {
            if (manager is Person m)
            {
                reportsTo = m;
            }
        }
    }
}
