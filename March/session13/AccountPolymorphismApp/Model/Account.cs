using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    internal abstract class Account
    {
        private readonly int _accouno;
        private readonly string _name;
        protected double _balance;


        public Account(int accouno, string name, double balance)
        {
            _accouno = accouno;
            _name = name;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public abstract void Withdraw(double amount);

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
    }
}
