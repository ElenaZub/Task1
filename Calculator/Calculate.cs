using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        public void DoOperation()
        {
            Operation[] operations =
            {
                new SumOperation(2, 4),
                new DivOperation(2, 1),
                new MultiplyOperation(4, 3),
            };
        
            foreach (var item in operations)
            {
                Console.WriteLine(item.Calculate());
                Console.WriteLine(item.ToString());
            }
        }       
    }
}
