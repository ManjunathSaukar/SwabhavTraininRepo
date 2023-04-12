using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    internal class SavingsAccount : Account
    {
        private const int MIN_BALANCE = 1000;
        public SavingsAccount(int accouno, string name, double balance) : base(accouno, name, balance)
        {

        }

        public override void Withdraw(double amount)
        {
            if (_balance > MIN_BALANCE)
            {
                _balance = _balance - amount;
                return;
            }
            throw new Exception("No Sufficient funds");
        }
    }
}
