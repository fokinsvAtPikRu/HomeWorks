using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Task2
{
    /// <summary>
    /// абстрактный класс для устройств без состояния
    /// </summary>
    public abstract class Device
    {
        /// <summary>
        /// имя устройства
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// комната в котором находится устройство, enum Zone
        /// </summary>
        public Zone Zone { get; }
        /// <summary>
        /// тип устройства, enum DevicesType
        /// </summary>
        public abstract DevicesType DeviceType { get;  }
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="zone"></param>
        public Device(string name, Zone zone)
        {
            Name = name;
            Zone = zone;            
        }
    }
}
