using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Device: ISwitchable
    {
        public State DeviceState { get; set; }

        public Device(State state)
        {
            this.DeviceState = state;
        }

        public Device()
        {
            this.DeviceState = State.Off;
        }

        public void TurnOn()
        {
            this.DeviceState = State.On;
        }

        public void TurnOff()
        {
            this.DeviceState = State.Off;
        }

        public override string ToString()
        {
            return ($"{this.GetType().Name} is {this.DeviceState} ");
        }
    }
}
