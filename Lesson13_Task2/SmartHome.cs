using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Task2
{
    /// <summary>
    /// класс умный дом
    /// </summary>
    internal class SmartHome
    {
        /// <summary>
        /// список умных устройств
        /// </summary>
        List<Device> devices = new List<Device>();
        /// <summary>
        /// метод добавляет умное устройство
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="name"></param>
        /// <param name="zone"></param>
        public void AddSmartDevices(IDeviceFactory factory, string name, Zone zone)
        {
            var newDevice = factory.CreateDevice(name, zone);
            devices.Add(newDevice);
            if (newDevice is SmartDevice<int> intDevice)
            {
                intDevice.DeviceStateChanged += (deviceType, name, zone, state, time) =>
                Show<int>(deviceType, name, zone, state, time);
            }
            else if (newDevice is SmartDevice<bool> boolDevice)
            {
                boolDevice.DeviceStateChanged += (deviceType, name, zone, state, time) =>
                Show<bool>(deviceType, name, zone, state, time);
            }
        }
        /// <summary>
        /// вывод в консоль сведений об изменении статуса устройств
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="deviceType"></param>
        /// <param name="name"></param>
        /// <param name="zone"></param>
        /// <param name="state"></param>
        /// <param name="time"></param>
        public void Show<T>(DevicesType deviceType, string name, Zone zone, T state, DateTime time)
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"DeviceType = {deviceType}");
            Console.WriteLine($"DeviceName = {name}");
            Console.WriteLine($"Room = {zone}");
            Console.WriteLine($"DeviceStatus = {state}");
            Console.WriteLine($"EventTime = {time}");            
            Console.WriteLine(new string('-', 40));
        }
        /// <summary>
        /// удаляет устройство из списка по имени, по хорошему надо ввести поле id в класс Device, сейчас разные устройство могут иметь одинаковое имя
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool RemoveSmartDevices(string name)
        {
            var deviceToRemove = devices.FirstOrDefault(x => x.Name == name);
            if (deviceToRemove != null)
            {
                devices.Remove(deviceToRemove);
                return true;
            }
            return false;
        }
        /// <summary>
        /// включает/выключает свет в комнате
        /// </summary>
        /// <param name="zone"></param>
        /// <param name="lightOn true - включить свет, false - выключить"></param>
        public void ChangeLight(Zone zone, bool lightOn)
        {
            var lamps = devices.
                Where(x => x.Zone == zone && x is ILight).
                Cast<ILight>();
            foreach (var lamp in lamps)
            {
                if (lightOn)
                    lamp.TurnLightOn();
                else lamp.TurnLightOff();
            }
        }
        /// <summary>
        /// открывает/закрывает замки в дверях комнаты
        /// </summary>
        /// <param name="zone"></param>
        /// <param name="locked true - закрыть, false - открыть"></param>
        public void ChangeDoorLocked(Zone zone, bool locked)
        {
            var doors = devices.
                Where(x => x.Zone == zone && x is IDoor).
                Cast<IDoor>();
            foreach (var door in doors)
            {
                if (locked)
                    door.LockDoor();
                else
                    door.UnLockDoor();
            }
        }
        /// <summary>
        /// устанавливает температуру в комнате
        /// </summary>
        /// <param name="zone"></param>
        /// <param name="temperature"></param>
        public void ChangeTemptrature(Zone zone, int temperature)
        {
            var thermostats = devices.
                Where(x => x.Zone == zone && x is IThermostat).
                Cast<IThermostat>();
            foreach (var thermostat in thermostats)
            {
                thermostat.SetTemperature(temperature);
            }
        }
    }
}
