using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Monitor : Device
    {
        public MonitorBrand Brand { get; set; }

        public Monitor(MonitorBrand brand, State state):
            base(state)
        {
            this.Brand = brand;
        }

        public Monitor() 
        {
            this.Brand = MonitorBrand.Asus;
            this.DeviceState = State.Off;
        }

        public override string ToString()
        {
            return $"{this.Brand} {this.GetType().Name} is {this.DeviceState}";
        }
    }
}
