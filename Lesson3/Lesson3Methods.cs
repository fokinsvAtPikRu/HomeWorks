using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public static class Lesson3Methods
    {
        /// <summary>
        /// Task1
        /// </summary>
        /// <typeparam name="where T: IComparable"></typeparam>
        /// <param name="value0"></param>
        /// <param name="value1"></param>
        /// <returns></returns>
        public static char SignOfTheCompraisonResult<T>(T value0, T value1) where T : IComparable<T>
        {            
            var resultCompare = value0.CompareTo(value1);
            if (resultCompare == 0)
                return '=';
            else if (resultCompare < 0)
                return '<';
            else
                return '>';
        }

    }
}
