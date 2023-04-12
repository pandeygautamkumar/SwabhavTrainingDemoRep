using AccountApp.Model;
using System;

namespace AccountUnitTest
{
    [TestClass]
    internal class AccountTest
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
            Assert.AreEqual(expectedName,acc1.Name);
            Assert.AreEqual(expectedAccountNo,acc1.AccountNo);
        }
        [TestMethod]
        public void ShouldCreateAccountHolder_WithInitialBalanceOf_1000()
        {
            double expectedBalance =1000;
            Account acc1 = new Account(101,1000, "Gautam");
            double actualBalance = acc1.Balance;
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldThroughExceptionIfCreateAccountHolder_WithInitialBalanceOfBelow_500()
        {
            Account acc1 = new Account(101, 1000, "Gautam");
        }
    }
}
