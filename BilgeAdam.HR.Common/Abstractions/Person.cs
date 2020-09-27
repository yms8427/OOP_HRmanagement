using System;

namespace BilgeAdam.HR.Common.Abstractions
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            Id = 1; // TODO: handle
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public DateTime HireDate { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
