using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Task2
{
    interface IDeviceFactory
    {
        Device CreateDevice(string name, Zone zone);
    }

    internal class SmartLampFactory : IDeviceFactory
    {
        public Device CreateDevice(string name, Zone zone) => new SmartLamp(name, zone);
    }
    internal class SmartDoorFactory : IDeviceFactory
    {
        public Device CreateDevice(string name, Zone zone) => new SmartDoor(name, zone);        
    }
    internal class SmartThermostatFactory : IDeviceFactory
    {
        public Device CreateDevice(string name, Zone zone) => new SmartThermostat(name, zone);
    }
}
