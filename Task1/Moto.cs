using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Moto : Vehicle
    {
        public MotoType Type { get; set; }

        public Moto(MotoType type, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCoun)
            : base(wheelCount, color, maxSpeed, passengerCoun)
        {
            Type = type;
            Header += String.Format("{0,15}", "Type");
            Info += String.Format("{0,15}", Type);
        }   
    }
}