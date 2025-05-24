using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Task2
{
    internal class SmartLamp : SmartDevice<bool>, ILight
    {
        public override DevicesType smartType => DevicesType.Light;
        public SmartLamp() 
        {
            State=false;
        }
        public void TurnLightOff()
        {
            State = false;
            DeviceStateChanged?.Invoke(smartType, State, DateTime.Now);
        }

        public void TurnLightOn()
        {
            State = true;
            DeviceStateChanged?.Invoke(smartType, State, DateTime.Now);
        }
    }
}
