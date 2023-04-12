using AccountPolymorphismApp.Model;
using System;

namespace AccountPolymorphismUnitTestApp
{
    [TestClass]
    public class AccountPolymorphismUnitTest
    {  
        [TestMethod]
        public void Should_Check_Account_Class_Constructor_Throught_CurrentAccount_Class_Constructor_By_Overriding_Constructor()
        {
            Account account = new CurrentAccount(11011, "Gautam Pandey", 12000);
            int expectedAccountNo = 11011;
            string expectedName = "Gautam Pandey";
            double expectedBalance = 12000;

            Assert.AreEqual(expectedAccountNo,account.AccountNo);
            Assert.AreEqual(expectedName,account.Name);
            Assert.AreEqual(expectedBalance,account.Balance);
        }
        [TestMethod]
        public void Should_Check_Account_Class_Constructor_Throught_SavingAccount_Class_Constructor_By_Overriding_Constructor()
        {
            Account account = new SavingsAccount(11012, "Ravi", 15000);
            int expectedAccountNo = 11012;
            string expectedName = "Ravi";
            double expectedBalance = 15000;

            Assert.AreEqual(expectedAccountNo, account.AccountNo);
            Assert.AreEqual(expectedName, account.Name);
            Assert.AreEqual(expectedBalance, account.Balance);
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Should_Throw_Exception_If_Withdraw_Amount_Is_Below_1000_InSaving_Account()
        {
            Account account = new SavingsAccount(11012, "Ravi", 15000);
            account.Withdraw(14000);
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Should_Throw_Exception_If_OverDraftAmount_Is_Below_Negative_5000_InCurrentAccount()
        {
            Account account = new CurrentAccount(11011, "Gautam Pandey", 12000);
            account.Withdraw(18000);
        }

        [TestMethod]
        public void Should_Check_Deposit_If_Deposit_Some_AmmountIn_SavingAccount()
        {
            Account account = new SavingsAccount(11012, "Ravi", 15000);
            account.Deposit(5000);
            double expectedBalance = 20000;
            Assert.AreEqual(expectedBalance, account.Balance);
        }
        [TestMethod]
        public void Should_Check_Deposit_If_Deposit_Some_AmmountIn_CurrentAccount()
        {
            Account account = new CurrentAccount(11011, "Gautam Pandey", 12000);
            account.Deposit(5000);
            double expectedBalance = 17000;
            Assert.AreEqual(expectedBalance, account.Balance);
        }
    }
}
