using System;

namespace Persons
{
    public class Employee:Person
    {
        public string JobTitle { set; get; }
        
        public void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine(JobTitle);
            Console.WriteLine(Address);
            Console.WriteLine(Id);
        }
    }
}