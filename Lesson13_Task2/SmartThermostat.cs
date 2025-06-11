using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Task2
{
    /// <summary>
    /// класс умный термостат
    /// </summary>
    internal class SmartThermostat : SmartDevice<int>, IThermostat
    {
        /// <summary>
        /// устанавливает тип умного устройства - умный термостат
        /// </summary>
        public override DevicesType DeviceType => DevicesType.Thermostat;
        /// <summary>
        /// конструктор, тепература устанавливается в 20 градусов
        /// </summary>
        /// <param name="name"></param>
        /// <param name="zone"></param>
        public SmartThermostat(string name,Zone zone):base(name, zone) 
        {
            State = 20;
        }
        /// <summary>
        /// метод изменяет температуру
        /// </summary>
        /// <param name="value - устанавливаемя температура"></param>
        /// <exception cref="ArgumentOutOfRangeException - температура вне допустимого диапазона"></exception>
        public void SetTemperature(int value)
        {
            if (value > 15 && value < 30)
                State = value;
            else
                throw new ArgumentOutOfRangeException();
            OnDeviceStateChanged(DeviceType, Name, Zone, State, DateTime.Now);
        }
    }
}
