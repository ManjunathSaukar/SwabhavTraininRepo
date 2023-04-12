using AccountPolymorphismUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismUnitTestApp
{
    [TestClass]
    public class AccountPolymorphismTest
    {
        [TestMethod]
        public void Should_Deposit_Amount_In_Savings_Account()
        {
            Account account = new SavingsAccount(101, "Manjunath", 5000);
            account.Deposit(1000);
            double expectedBalance = 6000;
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [TestMethod]
        public void Should_Withdraw_Amount_From_Savings_Account()
        {
            Account account = new SavingsAccount(101, "Manjunath", 5000);
            account.Withdraw(2000);
            double expectedBalance = 3000;
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Should_Not_Withdraw_Amount_From_Savings_Account_If_Balance_Is_Less_Than_Minimum_Else_Exception_Is_Thrown()
        {
            Account account = new SavingsAccount(101, "Manjunath", 500);
            account.Withdraw(100);
        }

        [TestMethod]
        public void Should_Deposit_Amount_In_Current_Account()
        {
            Account account = new CurrentAccount(101, "Abhi", 5000);
            account.Deposit(1000);
            double expectedBalance = 6000;
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [TestMethod]
        public void Should_Withdraw_Amount_From_Current_Account()
        {
            Account account = new CurrentAccount(101, "Abhi", 5000);
            account.Withdraw(2000);
            double expectedBalance = 3000;
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Should_Not_Withdraw_Amount_From_Current_Account_If_Balance_Is_Less_Than_OverDraft_Limit_Else_Exception_is_Thrown()
        {
            Account account = new CurrentAccount(101, "Abhi", 2000);
            account.Withdraw(10000);
        }
    }
}
