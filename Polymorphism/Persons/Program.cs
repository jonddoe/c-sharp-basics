using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentEntry = new Student
            {
                Gpa = 99.6,
                FirstName = "Jon",
                LastName = "Doe",
                Address = "2nd street",
                Id = 617
            };

            var employeeEntry = new Employee
            {
                JobTitle = "OP",
                FirstName = "Jane",
                LastName = "Doe",
                Address = "3rd street",
                Id = 711
            };
            studentEntry.Display();
            employeeEntry.Display();
            Console.Read();
        }
    }
}