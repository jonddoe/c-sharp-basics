using System;

namespace Persons
{
    public class Student : Person
    {
        public double Gpa { set; get; }
        
        public void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine(Gpa);
            Console.WriteLine(Address);
            Console.WriteLine(Id);
        }
    }
}