using System;

namespace Exercise_8
{
    class SavingsAccount
    {
        private int _balance;
        private decimal _monthlyInterest;
        private int _accMonthAge;
        private decimal _monthlyDeposit;
        private decimal _monthlyWithdrawal;

        public void SetValuesToAcc(int balance, decimal interest, int age)
        {
            _balance = balance;
            _monthlyInterest = (interest / 100) / 12;
            _accMonthAge = age;
        }

        public void SetDepositWithdrawal(decimal d, decimal w)
        {
            _monthlyDeposit = d;
            _monthlyWithdrawal = w;
        }


        public decimal CalculateInterest()
        {
            return Convert.ToDecimal((_balance + (_monthlyDeposit - _monthlyWithdrawal)) *
                                     (_monthlyInterest * _accMonthAge));
        }

        public decimal CalculateEndingBalance()
        {
            return (Convert.ToDecimal(_balance) + CalculateInterest()) + (_monthlyDeposit - _monthlyWithdrawal);
        }
    }
}
