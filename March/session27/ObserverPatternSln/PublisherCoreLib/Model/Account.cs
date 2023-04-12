﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherCoreLib.Model
{
    public class Account
    {
        private readonly int _accouno;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        private readonly List<IAccountNotifier> _notifications;

        public Account(int accouno, string name, double balance)
        {
            _accouno = accouno;
            _name = name;
            _balance = balance;
            _notifications = new List<IAccountNotifier>();
        }

        public Account(int accouno, string name) :this (accouno,name,MIN_BALANCE)
        {
            
        }
        public void AddSubscriber(IAccountNotifier notifier)
        {
            _notifications.Add(notifier);
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            foreach(IAccountNotifier notifier  in _notifications)
            {
                notifier.Notify(this);
            }
        }

        public void Withdraw(double amount)
        {
            if (SufficientFundsAvailable(amount))
            {
                _balance -= amount;
                foreach (IAccountNotifier notifier in _notifications)
                {
                    notifier.Notify(this);
                }
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
    }
}
