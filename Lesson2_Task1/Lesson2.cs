using System;
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
        public static (int,int,double) ConvertInchToMeter(double inch) 
        {
            double milimeter = inch * 25.4;
            int meter = (int)milimeter / 1000;
            int santimeter = (int)milimeter % 1000 /10;
            milimeter = milimeter % 10;
            return (meter, santimeter, milimeter);
        }
        public static int SwapSecondAndFourthFigure(int startNumber)
        {
            int secondFigure = (startNumber % 100 / 10);// *10;
            int fourtFigure = (startNumber % 10000 / 1000);// * 1000;
            return startNumber-secondFigure*10-fourtFigure*1000+secondFigure*1000+fourtFigure*10;
        }
        public static decimal RoundUp(decimal length)=>Ceiling(length);
        public static decimal RoundToHalf(decimal length) =>
            Round(length * 2) / 2;
    }
}
