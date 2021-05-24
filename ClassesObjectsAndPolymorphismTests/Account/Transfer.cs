namespace Account
{
    public class Transfer 
    {
        public Transfer(Account from, Account to, double howMuch)
        {
            to.Deposit(from.Withdrawal(howMuch));
        }
    }
}