
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FridgeEventArgs : EventArgs
    {
        private DoorState freezerDoor;

        private DoorState mainDoor;

        private PowerState fridgePower;

        public DoorState FreezerDoor
        {
            get
            {
                return this.freezerDoor;
            }
        }

        public DoorState MainDoor
        {
            get
            {
                return this.mainDoor;
            }
        }

        public PowerState FridgePower
        {
            get
            {
                return this.fridgePower;
            }
        }

        public FridgeEventArgs(DoorState freezerDoor, DoorState mainDoor, PowerState fridgePower)
        {
            this.freezerDoor = freezerDoor;
            this.mainDoor = mainDoor;
            this.fridgePower = fridgePower;
        }
    }
}