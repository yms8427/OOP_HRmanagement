using BilgeAdam.HR.Common.Abstractions;
using System;

namespace BilgeAdam.HR.Common.Models
{
    public class Intern : Person, ITemporaryEmployee
    {
        public Intern(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public DateTime LastWorkingDate { get; set; }
    }
}