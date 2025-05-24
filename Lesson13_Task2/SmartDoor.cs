using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Task2
{
    internal class SmartDoor : SmartDevice<DoorState>, IDoor
    {
        public override DevicesType smartType => DevicesType.Door;

        public void LockDoor()
        {
            State = DoorState.Close;
            DeviceStateChanged?.Invoke(smartType, State, DateTime.Now);
        }

        public void UnLockDoor()
        {
            State = DoorState.Open;
            DeviceStateChanged?.Invoke(smartType, State, DateTime.Now);
        }
    }
}
