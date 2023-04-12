using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPolymorphismApp.Model
{
    internal class InsufficientFundsException : Exception
    {
        private readonly double _withdrawAmt;
        public InsufficientFundsException(Account account, double withdrawAmt)
        {
            Account = account;
            _withdrawAmt= withdrawAmt;
        }
        public Account Account { get; }
        public double WithdrawAmt { get { return _withdrawAmt; } }
        public override string Message
        {
            get
            {
                string message = $"SBI says \n" +
                    $"Account No : {Account.Accouno} \n" +
                    $"Owner : {Account.Name} \n" +
                    $"tried withdrawing {WithdrawAmt} \n" +
                    $"Current balance is only {Account.Balance} \n" +
                    $"Minimum balance 500 " +
                    $"has to be maintained  \n" +
                    $"Hence current transaction failed";
                return message;
            }
        }
    }
}
