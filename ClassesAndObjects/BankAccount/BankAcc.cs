using System;

namespace BankAccount
{
    class BankAcc
    {
        private readonly double _balance = -17.25;
        private readonly string _name = "Benson";

        public string ShowUserNameAndBalance()
        {
            if (_balance < 0)
            {
                return _name + ", -$" + (Math.Abs(_balance).ToString("F2"));
            }

            return _name + ", $" + _balance.ToString("F2");
        }
    }
}
