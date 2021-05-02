using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var benben = new BankAcc();
            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.ReadLine();
        }
    }
}