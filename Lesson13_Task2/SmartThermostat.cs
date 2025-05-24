using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Task2
{
    internal class SmartThermostat : SmartDevice<int>, IThermostat
    {
        public override DevicesType smartType => DevicesType.Thermostat;
        public SmartThermostat()
        {
            State = 20;
        }

        public void SetTemperature(int value)
        {
            if (value > 15 && value < 30)
                State = value;
            else
                throw new ArgumentOutOfRangeException();
            DeviceStateChanged?.Invoke(smartType, State, DateTime.Now);
        }
    }
}
