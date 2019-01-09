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
            Assert.Equal("Tyler your balance is $10",Program.Balance("Tyler", "10"));
        }

        [Fact]
        public void TestingWithdrawMethod()
        {
            Assert.Equal("5",Program.Withdraw("10", "5"));
        }

        [Fact]
        public void TestingDepositMethod()
        {
            Assert.Equal("15", Program.Deposit("10", "5"));
        }
    }
}
