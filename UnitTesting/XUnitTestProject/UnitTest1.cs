using System;
using Xunit;
using UnitTesting;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestingBalanceMethod()
        {
            Assert.Equal("10",Program.Balance("Tyler", "10"));
        }

        [Fact]
        public void TestingWithdrawMethod()
        {
            Assert.Equal("5",Program.Withdraw("Tyler", "10", "5"));
        }

        [Fact]
        public void TestingDepositMethod()
        {
            Assert.Equal("15", Program.Deposit("10", "5"));
        }

        [Theory]
        [InlineData("Brett", "100")]
        public void TheoryTestBalace(string user, string balance)
        {
            Assert.Equal("100", Program.Balance(user, balance));
        }

        [Theory]
        [InlineData("Brett", "100", "50")]
        public void TheoryTestWithdraw(string user, string balance, string amount)
        {
            Assert.Equal("50", Program.Withdraw(user, balance, amount));
        }

        [Theory]
        [InlineData("100", "50")]
        public void TheoryTestDeposit(string balance, string amount)
        {
            Assert.Equal("150", Program.Deposit(balance, amount));
        }

        
    }
}
