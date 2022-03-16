using System;
using Xunit;
using UnitTests;

namespace TestATM
{
    public class UnitTest1
    {
        // balance default value = 1000.
        [Fact]
        public void TestPassDeposit()
        {
            // Checks if blance + 1000 == Deposite(1000)
            Assert.Equal(Program.balance +1000, Program.Deposit(1000));

            // It will return the balance without modifying it
            // Because depositing negative amounts of money is not allowed
            Assert.Equal(Program.balance, Program.Deposit(-1000));
            Assert.Equal(Program.balance + 500, Program.Deposit(500));
        }
        [Fact]
        public void TestFailDeposit()
        {
            // Depositing negative amounts of money is not allowed
            // so it should fail, Expected: -1 but Actual: 1000
            Assert.Equal(Program.balance - 1001, Program.Deposit(-1001));
            // Expected: -1 but Actual: 1000
            Assert.Equal(Program.balance - 2000, Program.Deposit(-2000));
        }
        [Fact]
        public void TestPassWithDraw()
        {
            // It will return the balance - ammount of money to WithDraw so it will pass
            Assert.Equal(Program.balance - 100, Program.WithDraw(100));
            Assert.Equal(Program.balance - 900, Program.WithDraw(900));
           
        }
        [Fact]
        public void TestFailWithDraw()
        {
            // It will fail because you can't be WithDraw negative amounts of money
            // so it returns the original balance, Expected: 900 Actual 1000
            Assert.Equal(Program.balance - 100, Program.WithDraw(-100));

            // It will fail because balance can't be below zero...
            Assert.Equal(Program.balance - 2000, Program.WithDraw(2000));
        }

    }
}
