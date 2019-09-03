using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Operation
    {
        public int FirstValue { get; set; }

        public int SecondValue { get; set; }

        public virtual string Action { get; set; }

        public Operation(int firstValue, int secondValue)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
        }

        public override string ToString()
        {
            return $"The calculation is performed using the {this.Action} operation.";
        }

        public abstract double Calculate();
    }
}
