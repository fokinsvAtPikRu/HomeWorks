using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class Bird : IFlyable
    {
        public int MaxAltitude { get; }
        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }
        public string Fly() => $"Лечу на высоте {MaxAltitude} метров";        
    }
}
