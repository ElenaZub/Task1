using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{ 
    class FridgeEventArgs: EventArgs
    {
        public FridgeState State { get; set; }

        public FridgeEventArgs(FridgeState state)
        {
            State = state;
        }
    }
}
