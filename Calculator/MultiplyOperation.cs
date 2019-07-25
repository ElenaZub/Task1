using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MultiplyOperation : Operation
    {

        public override string Action
        {
            get
            {
                return Action = "multiply";
            }
        }

        public MultiplyOperation(int firstValue, int secondValue) :
           base(firstValue, secondValue)
        {
        }

        public override double Calculate()
        {
            return this.FirstValue * this.SecondValue;
        }
    }
}
