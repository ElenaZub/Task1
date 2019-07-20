using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Fridge
    {
        public delegate void FridgeDelegate(object sender, FridgeEventArgs e);

        public event FridgeDelegate NewFridgeState;

        public FridgeState State { get; set; }

        public FridgeState CurrentState()
        {
            return this.State;
        }

        public void ChangeState(FridgeState state)
        {
            this.State = state;
        }

        protected virtual void OnNewFridgeState(FridgeEventArgs e)
        {
            if (NewFridgeState != null)
                NewFridgeState(this, e);
        }

        public void SendNewFridgeState(FridgeState state)
        {
            FridgeEventArgs arg = new FridgeEventArgs(FridgeState.turnOff);
            OnNewFridgeState(arg);
        }       
    }
}
