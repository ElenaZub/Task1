using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class TV: Device
    {
        public TVBrand Brand { get; set; }

        public TV(TVBrand brand, State state):
            base(state)
        {
            this.Brand = brand;
        }

        public TV() 
        {
            this.Brand = TVBrand.LG;
            this.DeviceState = State.Off;
        }

        public override string ToString()
        {
            return $"{this.Brand} {this.GetType().Name} is {this.DeviceState} ";
        }
    }
}
