using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPolymorphismApp.Model
{
    internal class InsufficientFundsException : Exception
    {
        private int _accno;
        private double _balance, _withdrawAmt;
        private string _name;

        public InsufficientFundsException(int accno, double balance, double withdrawAmt, string name)
        {
            _accno = accno;
            _balance = balance;
            _withdrawAmt = withdrawAmt;
            _name = name;
        }

        public override string Message
        {
            get
            {
                string message = $"SBI says \n" +
                    $"Account No : {_accno} \n" +
                    $"Owner : {_name} \n" +
                    $"tried withdrawing {_withdrawAmt} \n" +
                    $"Current balance is only {_balance} \n" +
                    $"Minimum balance 500 " +
                    $"has to be maintained  \n" +
                    $"Hence current transaction failed";
                return message;
            }
        }
    }
}
