using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public class MyClass
    {
        private string change;

        public string GetChange()
        {
            return this.change;
        }

        public void SetChange(string change)
        {
            this.change = change;
        }
    }
}
