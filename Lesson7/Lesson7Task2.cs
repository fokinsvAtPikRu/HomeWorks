using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public static partial class Lesson7
    {
        public static void CalcCube(double edgeCube, out double cubeVolume, double cubeArea)
        {
            cubeArea = 6*edgeCube*edgeCube;
            cubeVolume = edgeCube*edgeCube*edgeCube;
        }
    }
}
