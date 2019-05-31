using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Bicycle : Vehicle
    {
        public BicycleType Type { get; set; }

        public BreakType Breaks { get; set; }

        public Bicycle(BicycleType type, BreakType breaks, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCoun)
            : base(wheelCount, color, maxSpeed, passengerCoun)
        {
            Type = type;
            Breaks = breaks;
            Header += String.Format("{0,15} {1,15}", "Type", "Breaks");
            Info += String.Format("{0,15} {1,15}", Type, Breaks);
        }
    }
}