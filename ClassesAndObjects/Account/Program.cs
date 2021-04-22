using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mattsAccount = new Account("Matt's account", 100.00);
            var myAccount = new Account("My account", 0);
            var bobsAccount = new Account("Bob's account", 0);

            Console.WriteLine("Initial state\n");
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);
            Console.WriteLine(bobsAccount);

            mattsAccount.Withdrawal(100);
            myAccount.Deposit(100);
            Console.WriteLine("Matt's account balance is now: " + mattsAccount.Balance());
            Console.WriteLine("My account balance is now: " + myAccount.Balance());

            Transfer(mattsAccount, myAccount, 50.0);
            Transfer(myAccount, bobsAccount, 25.0);

            Console.WriteLine("\nFinal state\n");
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);
            Console.WriteLine(bobsAccount);
            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.Deposit(from.Withdrawal(howMuch));
        }
    }
}