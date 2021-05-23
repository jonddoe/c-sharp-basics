using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace Account.Tests
{
    [TestClass]
    public class AccountTests
    {
        [Fact]
        public void ToString_AddJonsAcc_ReturnNameAndBalance()
        {
            //arrange
            const string expected = "Jon: 100";
            //act
            var test = new Account("Jon", 100);

            var actual = test.ToString();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Deposit_AddJonsAccDeposit_ReturnNameAndBalanceUpdated()
        {
            //arrange
            const string expected = "Jon: 400";
            //act
            var test = new Account("Jon", 100);
            test.Deposit(300);
            var actual = test.ToString();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Withdrawal_AddJonsAccWithdraw_ReturnNameAndBalanceUpdated()
        {
            //arrange
            const string expected = "Jon: 45";
            //act
            var test = new Account("Jon", 100);
            test.Withdrawal(55);
            var actual = test.ToString();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Balance_AddJonsAcc_ReturnBalance()
        {
            //arrange
            const double expected = 103.55;
            //act
            var test = new Account("Jon", 103.55);

            var actual = test.Balance();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Balance_AddJonsAccDepositWithdraw_ReturnBalance()
        {
            //arrange
            const double expected = 101.65;
            //act
            var test = new Account("Jon", 103.55);
            test.Deposit(2.15);
            test.Withdrawal(4.05);
            var actual = test.Balance();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Transfer_FromJonToBob_ReturnBobsBalance()
        {
            //arrange
            const double expected = 55;
            //act
            var test = new Account("Jon", 100);
            var test2 = new Account("Bob", 0);

            new Transfer(test, test2, 55);
            var actual = test2.Balance();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Transfer_FromJonToBob_ReturnJonsBalance()
        {
            //arrange
            const double expected = 45;
            //act
            var test = new Account("Jon", 100);
            var test2 = new Account("Bob", 0);

            new Transfer(test, test2, 55);
            var actual = test.Balance();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}