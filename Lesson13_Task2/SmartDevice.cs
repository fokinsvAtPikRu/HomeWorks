using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Task2
{
    public delegate void DevicesStateChangedHandler<T1>(DevicesType deviceType, T1 state, DateTime time);
    public abstract class SmartDevice<T>
    {
        public abstract DevicesType smartType {  get; }
        public T State { get; set; }
        public DevicesStateChangedHandler<T> DeviceStateChanged;
    }
}
