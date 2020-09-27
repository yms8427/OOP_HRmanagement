using BilgeAdam.HR.Common.Abstractions;

namespace BilgeAdam.HR.Common.Models
{
    public class Manager : Person, IPermanentEmployee, IManager
    {
        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public decimal Salary { get; set; }

        public Person ReportsTo { get; set; }

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
                ReportsTo = m;
            }
        }
    }
}
