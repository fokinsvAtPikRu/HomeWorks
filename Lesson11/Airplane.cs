using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class Airplane : IFlyable
    {
        public int MaxAltitude { get; }
        public int CountPassengers { get; }
        public Airplane(int maxAltitude,int countPassengers)
        {
            MaxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }
        public string Fly() => $"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров";
    }
}
