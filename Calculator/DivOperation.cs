using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class DivOperation : Operation
    {
        public override string Action
        {
            get
            {
                return this.Action = "division";
            }               
        }

        public DivOperation(int firstValue, int secondValue) :
           base(firstValue, secondValue)
        {
        }

        public override double Calculate()
        {
            if (this.SecondValue != 0)
            {
                return (double)FirstValue / SecondValue;
            }
            else
                throw new DivideByZeroException();
        }
    }
}
