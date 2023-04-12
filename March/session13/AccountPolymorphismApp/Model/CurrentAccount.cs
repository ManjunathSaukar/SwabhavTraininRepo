using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    internal class CurrentAccount : Account
    {
        private const int OVER_DRAFT_LIMIT = -5000;
        public CurrentAccount(int accouno, string name, double balance) : base(accouno, name, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if(_balance-amount >= OVER_DRAFT_LIMIT) 
            {
                _balance -= amount;
                return;
            }
            throw new Exception("Over Draft Limt has been exceded");
        }
    }
}
