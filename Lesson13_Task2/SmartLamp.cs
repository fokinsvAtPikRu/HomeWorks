using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Task2
{
    /// <summary>
    /// класс умная лампа
    /// </summary>
    internal class SmartLamp : SmartDevice<bool>, ILight
    {
        /// <summary>
        /// устанавливается тип устройства - умная лампа
        /// </summary>
        public override DevicesType DeviceType => DevicesType.Light;
        /// <summary>
        /// конструктор, при создании лампы выключена
        /// </summary>
        /// <param name="name"></param>
        /// <param name="zone"></param>
        public SmartLamp(string name, Zone zone) : base(name, zone)
        {
            State = false;
        }
        /// <summary>
        /// метод выключает лампу
        /// </summary>
        public void TurnLightOff()
        {
            State = false;
            OnDeviceStateChanged(DeviceType, Name, Zone, State, DateTime.Now);
        }
        /// <summary>
        /// метод включает лампу
        /// </summary>
        public void TurnLightOn()
        {
            State = true;
            OnDeviceStateChanged(DeviceType, Name, Zone, State, DateTime.Now);
        }
    }
}
