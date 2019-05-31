using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Car : Vehicle
    {
        public int DoorsCount { get; set; }

        public EngineType EngineType { get; set; }

        public Gearbox Gearbox { get; set; }

        public Car(int doorsCount, EngineType engineType, Gearbox gearbox, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCoun)
            : base(wheelCount, color, maxSpeed, passengerCoun)
        {
            DoorsCount = doorsCount;
            EngineType = engineType;
            Gearbox = gearbox;
            Header += String.Format("{0,15} {1,15} {2,15}", "DoorsCount", "EngineType", "Gearbox");
            Info += String.Format("{0,15} {1,15} {2,15}", DoorsCount, EngineType, Gearbox);
        }
    }
}
