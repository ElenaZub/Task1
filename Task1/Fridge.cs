
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public delegate void FridgeDelegate(object sender, FridgeEventArgs e);

    public class Fridge
    {
        public DoorState FreezerDoor { get; set; }

        public DoorState MainDoor { get; set; }

        public PowerState FridgePower { get; set; }

        public event FridgeDelegate FridgeStateChange;

        public Fridge(DoorState freezeDoor, DoorState mainDoor, PowerState fridgePower)
        {
            this.FreezerDoor = freezeDoor;
            this.MainDoor = mainDoor;
            this.FridgePower = fridgePower;
        }

        public Fridge()
        {
        }

        public void OpenFreezerDoor()
        {
            this.FreezerDoor = DoorState.open;

            OnFridgeStateChange(this, new FridgeEventArgs(this.FreezerDoor, this.MainDoor, this.FridgePower));
        }

        public void CloseFreezerDoor()
        {
            this.FreezerDoor = DoorState.close;

            OnFridgeStateChange(this, new FridgeEventArgs(this.FreezerDoor, this.MainDoor, this.FridgePower));
        }

        public void OpenMainDoor()
        {
            this.MainDoor = DoorState.open;

            OnFridgeStateChange(this, new FridgeEventArgs(this.FreezerDoor, this.MainDoor, this.FridgePower));
        }

        public void CloseMainDoor()
        {
            this.MainDoor = DoorState.close;

            OnFridgeStateChange(this, new FridgeEventArgs(this.FreezerDoor, this.MainDoor, this.FridgePower));
        }

        public void TurtOnFridge()
        {
            this.FridgePower = PowerState.on;

            OnFridgeStateChange(this, new FridgeEventArgs(this.FreezerDoor, this.MainDoor, this.FridgePower));
        }

        public void TurtOffFridge()
        {
            this.FridgePower = PowerState.off;

            OnFridgeStateChange(this, new FridgeEventArgs(this.FreezerDoor, this.MainDoor, this.FridgePower));
        }

        protected virtual void OnFridgeStateChange(object sender, FridgeEventArgs e)
        {
            if (FridgeStateChange != null)
                this.FridgeStateChange(sender, e);
        }
    }
}