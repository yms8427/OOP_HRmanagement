using BilgeAdam.HR.Common.Abstractions;
using System;

namespace BilgeAdam.HR.Common.Models
{
    public class Worker : Person, IPermanentEmployee
    {
        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Person ReportsTo { get; }

        public decimal Salary { get; set; }

        public void SetManager(IManager manager)
        {
            throw new NotImplementedException();
        }
    }
}
