﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static System.Math;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public static class Lesson2
    {
        public static void SwapTwoNumbersWithoutThirdVariable<T>(ref T firstNumber, ref T secondNumber)
            where T : IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>
        {
            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
        }
        public static void SwapThreeVariables<T>(ref T firstNumber, ref T secondNumber, ref T thirdNumber)
        {
            T temp = thirdNumber;
            thirdNumber = secondNumber;
            secondNumber=firstNumber;
            firstNumber = temp;
        }
        public static double AngleFromDegreesToRadians(int angleDegrees, int angleMinutes, int angleSeconds)
            => (angleDegrees % 360 + angleMinutes / (0.6*100) + angleSeconds / (0.6*0.6*100*100)) * PI / 180;
        public static void Foo() { }
    }
}
