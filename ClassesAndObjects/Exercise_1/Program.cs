using System;

namespace Exercise_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product("Logitech mouse", 70.00, 14);
            var phone = new Product("iPhone 5s", 999.99, 3);
            var printer = new Product("Epson EB-U05", 440.46, 1);

            Console.WriteLine(mouse.PrintProduct());
            Console.WriteLine(phone.PrintProduct());
            Console.WriteLine(printer.PrintProduct());
            Console.ReadLine();

            mouse.ChangePrice(99.99);
            mouse.ChangeAmount(44);

            phone.ChangePrice(889.99);
            phone.ChangeAmount(74);

            printer.ChangePrice(290.95);
            printer.ChangeAmount(240);

            Console.WriteLine(mouse.PrintProduct());
            Console.WriteLine(phone.PrintProduct());
            Console.WriteLine(printer.PrintProduct());
        }
    }
}