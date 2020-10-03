using BilgeAdam.HR.Common.Abstractions;
using BilgeAdam.HR.Common.Enums;

namespace BilgeAdam.HR.Common.Models
{
    public class Manager : Person, IPermanentEmployee, IManager
    {
        private Person reportsTo;
        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public decimal Salary { get; set; }

        public Person ReportsTo { get { return reportsTo; } }
        public Department Department { get; set; }

        public void SetEmployees(params Person[] employees)
        {
            foreach (var emp in employees)
            {
                if (emp is Employee e)
                {
                    e.SetManager(this);
                }
            }
        }

        public void SetManager(IManager manager)
        {
            if (manager is Person m)
            {
                reportsTo = m;
            }
        }
    }
}
