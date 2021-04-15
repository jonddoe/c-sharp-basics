using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc = new SavingsAccount();

            Console.WriteLine("How much money is in the account?:");
            int.TryParse(Console.ReadLine(), out var balance);
            Console.WriteLine("Enter the annual interest:");
            decimal.TryParse(Console.ReadLine(), out var interest);
            Console.WriteLine("How long has the account been opened?");
            int.TryParse(Console.ReadLine(), out var accAge);

            acc.SetValuesToAcc(balance, interest, accAge);

            var totalDeposit = 0.00M;
            var totalWithdrawal = 0.00M;
            for (var i = 1; i <= accAge; i++)
            {
                Console.WriteLine($"Enter amount deposited for month: {i}:");
                int.TryParse(Console.ReadLine(), out var deposit);
                Console.WriteLine($"Enter amount withdrawn for month: {i}:");
                int.TryParse(Console.ReadLine(), out var withdrawal);
                totalDeposit += deposit;
                totalWithdrawal += withdrawal;
            }

            acc.SetDepositWithdrawal(totalDeposit, totalWithdrawal);

            Console.WriteLine($"Total deposited: ${totalDeposit}");
            Console.WriteLine($"Total withdrawn: ${totalWithdrawal}");
            Console.WriteLine($"Interest earned: ${acc.CalculateInterest():N2}");
            Console.WriteLine($"Ending balance: ${acc.CalculateEndingBalance():N2}");
        }
    }
}