using AccountApp.Model;
using System;

namespace AccountTestApp
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void ShouldCreateAccountHolder_WithInitialBalanceOf_500()
        {
            double expectedBalance = 500;
            string expectedName = "Gautam";
            int expectedAccountNo = 101;
            Account acc1 = new Account(101, "Gautam");
            double actualBalance = acc1.Balance;
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedName, acc1.Name);
            Assert.AreEqual(expectedAccountNo, acc1.AccountNo);
        }
        [TestMethod]
        public void ShouldCreateAccountHolder_WithInitialBalanceOf_1000()
        {
            double expectedBalance = 1000;
            Account acc1 = new Account(101, 1000, "Gautam");
            double actualBalance = acc1.Balance;
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldThroughExceptionIfCreateAccountHolder_WithInitialBalanceOfBelow_500()
        {
            Account acc1 = new Account(101, 499 , "Gautam");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldThroughExceptionIfWithdrawAmount_InBelow_500()
        {
            Account acc1 = new Account(101,1000, "Gautam");
            acc1.Withdraw(1000);
        }
        [TestMethod]
        public void ShouldAmmountWillbAdded()
        {
            int expectedBalance = 2000;
            Account acc1 = new Account(101, 1000, "Gautam");
            acc1.Deposit(1000);
            Assert.AreEqual(expectedBalance,acc1.Balance);
        }
    }
}
