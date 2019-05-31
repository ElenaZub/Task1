using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Vehicle
    {
        private int wheelCount = 1;

        public ConsoleColor Color { get; set; }

        private int maxSpeed = 1;

        public int PassengerCount { get; set; }

        public int WheelCount
        {
            get
            {
                return wheelCount;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Wheel should be more than 0");
                }
                else wheelCount = value;
            }
        }
        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if (value > 0)
                {
                    maxSpeed = value;
                }
                throw new Exception("Max speed should be more than 0");
            }
        }

        public string Header { get; set; }

        public string Info { get; set; }

        public Vehicle(int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
        {
            WheelCount = wheelCount;
            Color = color;
            MaxSpeed = maxSpeed;
            PassengerCount = passengerCount;
            Header = String.Format("{0,15} {1,15} {2,15} {3,15}", "WheelCount", "Color", "MaxSpeed", "PassengerCount");
            Info = String.Format("{0,15} {1,15} {2,15} {3,15}", WheelCount, Color, MaxSpeed, PassengerCount);
        }

        public void Move(int meters)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"{GetType().Name} has moved {meters} meters");
        }

        public void PrintTable()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(Header);
            Console.WriteLine(Info);
        }
    }
}
