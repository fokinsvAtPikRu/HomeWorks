using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Task2
{
    /// <summary>
    /// обработчик изменения состояния устройства
    /// </summary>
    /// <typeparam name="T" - тип для состояния устройства></typeparam>
    /// <param name="deviceType - тип устройства, enum DevicesType"></param>
    /// <param name="state - состояние устройства"></param>
    /// <param name="time - время когда произошло изменение состояния"></param>
    public delegate void DevicesStateChangedHandler<T>(DevicesType deviceType,string name, Zone zone, T state, DateTime time);
    /// <summary>
    /// абстрактный класс инкпсулириющий состояние устройства
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class SmartDevice<T> : Device
    {
        /// <summary>
        /// состояние устройства 
        /// </summary>
        public T State { get; set; }
        /// <summary>
        /// событие изменение состояния устройства
        /// </summary>
        public event DevicesStateChangedHandler<T> DeviceStateChanged;
        /// <summary>
        /// конструктор, наследуемый от базового типа
        /// </summary>
        /// <param name="name"></param>
        /// <param name="zone"></param>
        protected SmartDevice(string name, Zone zone) : base(name, zone) { }
        /// <summary>
        /// генерация события при изменении состояния устройства
        /// </summary>
        /// <param name="deviceType"></param>
        /// <param name="state"></param>
        /// <param name="time"></param>
        protected void OnDeviceStateChanged(DevicesType deviceType, string name, Zone zone, T state, DateTime time)
        {
            DeviceStateChanged?.Invoke(deviceType, name, zone, state, time);
        }
    }
}
