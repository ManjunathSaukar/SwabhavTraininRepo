using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactionApp.Model
{
    internal class Account
    {
        private readonly int _accouno;
        private double _balance = 0;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        private readonly List<Transaction> _transactions;

        public Account(int accouno, string name, double balance)
        {
            _accouno = accouno;
            _name = name;
            _balance = balance;
            _transactions= new List<Transaction>();
            _transactions.Add(new Transaction { Type = 'D', Amount=_balance,Time=DateTime.Now});
        }

        public Account(int accouno, string name) :this(accouno, name, MIN_BALANCE)
        {
            
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            _transactions.Add(new Transaction { Type = 'D', Amount=amount,Time=DateTime.Now});
        }

        public void Withdraw(double amount)
        {
            if (SufficientFundsAvailable(amount))
            {
                _balance -= amount;
                _transactions.Add(new Transaction { Type = 'W', Amount = amount, Time = DateTime.Now });
            }
            else
                Console.WriteLine("ERROR : No sufficient funds ");
        }
        public bool SufficientFundsAvailable(double withAmount)
        {
            double amountAfterWithdraw = _balance - withAmount;
            return amountAfterWithdraw >= MIN_BALANCE;
        }

        public double Accouno
        {
            get { return _accouno; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public string Name
        {
            get { return _name; }
        }

        public List<Transaction> Transactions 
        { 
            get { return _transactions; } 
        }
    }
}
