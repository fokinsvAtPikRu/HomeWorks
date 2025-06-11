using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson13_Task2
{
    /// <summary>
    /// умная дверь
    /// </summary>
    internal class SmartDoor : SmartDevice<bool>, IDoor
    {
        /// <summary>
        /// задается тип умного устройства - умная дверь
        /// </summary>
        public override DevicesType DeviceType => DevicesType.Door;
        /// <summary>
        /// конструктор, при создании дверь открыта
        /// </summary>
        /// <param name="name"></param>
        /// <param name="zone"></param>
        public SmartDoor(string name, Zone zone) : base(name, zone)
        {
            State=false;
        }
        /// <summary>
        /// метод закрывает дверь
        /// </summary>
        public void LockDoor()
        {
            State = true;
            OnDeviceStateChanged(DeviceType, Name, Zone, State, DateTime.Now);
        }
        /// <summary>
        /// метод открывает дверь
        /// </summary>
        public void UnLockDoor()
        {
            State = false;
            OnDeviceStateChanged(DeviceType, Name, Zone, State, DateTime.Now);
        }
    }
}
