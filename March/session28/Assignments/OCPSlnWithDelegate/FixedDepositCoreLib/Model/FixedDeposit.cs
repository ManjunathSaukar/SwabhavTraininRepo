﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDepositCoreLib.Model
{
    public delegate double DCalculateRate();
    public class FixedDeposit
    {
        private int _accno;
        private string _name;
        private double _principalAmount;
        private int _duration;
        private DCalculateRate _calculateRate;
        public FixedDeposit(int accno, string name, double principalAmount, int duration, DCalculateRate calculateRate)
        {
            _accno = accno;
            _name = name;
            _principalAmount = principalAmount;
            _duration = duration;
            _calculateRate = calculateRate;
        }
        public double SimpleInterest
        {
            get
            {
                return _principalAmount * _duration * _calculateRate();
            }
        }
    }
}
