using System;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var contact = new PhoneDirectory();

            Console.WriteLine("Enter a name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter a number: ");
            var number = Console.ReadLine();
            Console.ReadLine();
            contact.PutNumber(name, number);
        }
    }
}
