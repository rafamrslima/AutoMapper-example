
using System;

namespace automapper_test.Domain
{
    public class Person
    {
        public Person(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Active = true;
            CreatedAt = DateTime.Now;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
