using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Lesson8Task2
    {
        public static int ValidateAge(int age) =>
            age < 0 ? throw new ArgumentException("Возраст не может быть отрицательным!") :
                age > 150 ? throw new ArgumentOutOfRangeException("Слишком большой возраст") : age;
    }
}
