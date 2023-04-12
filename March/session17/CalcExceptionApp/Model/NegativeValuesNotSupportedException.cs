using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalcExceptionApp.Model
{
    internal class NegativeValuesNotSupportedException : Exception
    {
        private int _input1, _input2;
        public NegativeValuesNotSupportedException(int input1, int input2)
        {
            _input1 = input1;
            _input2 = input2;
        }
        public override string Message
        {
            get
            {
                string message = "";
                if(_input1 <0 && _input2 < 0)
                {
                    message += $"Negative values {_input1}, {_input2} are not supported";
                }
                else if (_input1 < 0)
                {
                    message += $"Negative value {_input1} is not supported";
                }
                else if (_input2 < 0)
                {
                    message += $"Negative value {_input2} is not supported";
                }
                return message;
            }
        }
    }
}
