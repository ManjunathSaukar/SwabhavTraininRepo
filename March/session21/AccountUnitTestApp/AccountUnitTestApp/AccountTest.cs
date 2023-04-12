using AccountUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUnitTestApp
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void ShouldCreateAccountHolder_WithInitialBalanceOf_500()
        {
            double expecteBalance = 500;
            string expectedName = "Manjunath";
            int expectedAccountNo = 101;
            Account acc1 = new Account(101,"Manjunath");
            double actualBalance = acc1.Balance;
            double actualAccountNo = acc1.Accouno;
            Assert.IsTrue(actualBalance == expecteBalance);
            Assert.AreEqual(expectedName, acc1.Name);
            Assert.AreEqual(expectedAccountNo,actualAccountNo);
        }

        [TestMethod]
        public void ShouldCreateAccountHolder_WithInitialBalanceOf_1000()
        {
            double expecteBalance = 1000;
            Account acc1 = new Account(101, "Manjunath",1000);
            double actualBalance = acc1.Balance;
            Assert.IsTrue(actualBalance == expecteBalance);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldThrowExceptionOn_CreateAccountHolder_WithInitialBalanceOf_Below_500()
        {
            Account acc1 = new Account(101, "Manjunath", 0);
        }

        [TestMethod]
        public void ShouldDepositAmountToAccount()
        {
            double expectedBalance = 1500;
            Account acc1 = new Account(101, "Manjunath", 1000);
            acc1.Deposit(500);
            double actualBalance = acc1.Balance;
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void ShouldWithdrawAmountFromAccount()
        {
            double expectedBalance = 700;
            Account acc1 = new Account(101, "Manjunath", 1000);
            acc1.Withdraw(300);
            double actualBalance = acc1.Balance;
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void ShouldNotWithdrawAmountFromAccountIfInsufficientFunds()
        {
            double expectedBalance = 1000;
            Account acc1 = new Account(101, "Manjunath", 1000);
            acc1.Withdraw(1500);
            double actualBalance = acc1.Balance;
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void ShouldCheckIfSufficientFundsAvailable()
        {
            bool expectedResult = true;
            Account acc1 = new Account(101, "Manjunath", 1000);
            bool actualResult = acc1.SufficientFundsAvailable(500);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldNotCheckIfSufficientFundsAvailableIfInsufficientFunds()
        {
            bool expectedResult = false;
            Account acc1 = new Account(101, "Manjunath", 1000);
            bool actualResult = acc1.SufficientFundsAvailable(1500);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
