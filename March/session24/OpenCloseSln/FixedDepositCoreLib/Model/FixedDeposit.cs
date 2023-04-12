using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDepositCoreLib.Model
{
    public class FixedDeposit
    {
        private int _accno;
        private string _name;
        private double _principalAmount;
        private int _duration;
        private IRatePolicy _ratePolicy;

        public FixedDeposit(int accno, string name, double principalAmount, int duration, IRatePolicy ratePolicy)
        {
            _accno = accno;
            _name = name;
            _principalAmount = principalAmount;
            _duration = duration;
            _ratePolicy = ratePolicy;

        }
        public double SimpleInterest
        {
            get 
            {
                return _principalAmount *_duration *_ratePolicy.CalculateRate();
            }
        }
    }
}
