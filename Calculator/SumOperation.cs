using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SumOperation : Operation
    {
        public override string Action
        {
            get
            {
                return this.Action = "sum";
            }
        }

        public SumOperation(int firstValue, int secondValue) :
            base(firstValue, secondValue)
        { 
        }

        public override double Calculate()
        {
            return this.FirstValue + this.SecondValue;
        }
    }
}
