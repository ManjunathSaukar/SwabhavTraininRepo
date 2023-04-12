using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPVoilationApp.Model
{
    internal class FixedDeposit
    {
        private int _accno;
        private string _name;
        private double _principalAmount;
        private int _duration;
        private FestivalTypes _festivalTypes;

        public FixedDeposit(int accno, string name, double principalAmount, int duration, FestivalTypes festivalTypes)
        {
            _accno = accno;
            _name = name;
            _principalAmount = principalAmount;
            _duration = duration;
            _festivalTypes = festivalTypes;

        }
        public double CalculateRate()
        {
            if (_festivalTypes == FestivalTypes.DIWALI)
                return 0.09;
            else if (_festivalTypes == FestivalTypes.NEW_YEAR)
                return 0.08;
            else
                return 0.07;
        }

        public double SimpleInterest
        {
            get {
                return _principalAmount *_duration *CalculateRate();
            }
        }
    }
}
