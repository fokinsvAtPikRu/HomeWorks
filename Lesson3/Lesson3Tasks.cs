using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;
using System.Threading.Tasks;

namespace Lesson3
{
    public static class Lesson3Tasks
    {
        /// <summary>
        /// Task 1
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
        /// <summary>
        /// Task 10
        /// </summary>
        /// <param name="houses"></param>
        /// <returns></returns>
        public static string SayWeBuildSomeHouses(int houses)
        {
            var result = new StringBuilder();
            // StringBuilder result = new StringBuilder($"Мы построили {houses}");
            if (houses < 0) return "Мы все поломали";
            if (houses > 10 && houses < 15)
                return result.AppendFormat("домов").ToString();
            switch (houses % 10)
            {
                case 1:
                    result.AppendFormat("дом");
                    break;
                case 2:
                case 3:
                case 4:
                    result.AppendFormat("дома");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    result.AppendFormat("домов");
                    break;
            }
            return result.ToString();
        }
        /// <summary>
        /// Task 11
        /// </summary>
        /// <param name="house1"></param>
        /// <param name="house2"></param>
        /// <param name="area"></param>
        /// <returns></returns>
        public static bool IsEnoughPlace((int p, int q) house1, (int r, int s) house2, (int a, int b) area)
        {
            (int length, int width) minArea;
            minArea.length = Max(Max(house1.p, house1.q), Max(house2.r, house2.s));
            minArea.width = Min(house1.p, house1.q) + Min(house2.r, house2.s);
            (int length, int width) areaOrder;
            areaOrder.length = Max(area.a, area.b);
            areaOrder.width = Min(area.a, area.b);
            return areaOrder.length >= minArea.length && areaOrder.width >= minArea.width;
        }
        public static string SayNumber(int value)
        {
            if (100 < value || value > 999) return "Ошибка! Число вне диапазона 100-999.";
            string[] hundreds = { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] secondTens = {"одиннадцать", "двенадцать", "тринадцать", "четырнадцать","пятнадцать",
                "шестнадцать","семнадцать", "восемнадцать", "девятнадцать"};
            string[] tens = {}
            var thirdFigure = value / 100;
            var secondFigure = value % 100 - value % 10;
            var firstFigure = value % 10;
            var result = new StringBuilder();
            switch (thirdFigure)
            {
                case 1:
                    result.AppendFormat("сто ");
                    break;
                case 2:
                    result.AppendFormat("двести ");
                    break;
                case 3:
                    result.AppendFormat("триста ");
                    break;
                case 4:
                    result.AppendFormat("четыреста ");
                    break;
                case 5:
                    result.AppendFormat("пятьсот ");
                    break;
                case 6:
                    result.AppendFormat("шестьсот ");
                    break;
                case 7:
                    result.AppendFormat("семьсот ");
                    break;
                case 8:
                    result.AppendFormat("восемьсот ");
                    break;
                case 9:
                    result.AppendFormat("девятьсот ");
                    break;
            }
            switch (value % 100)
            {
                case 11:
                    return result.AppendFormat("одиннадцать").ToString();                    
                case 12:
                    return result.AppendFormat("двенадцать").ToString();
                case 13:
                    return result.AppendFormat("тринадцать").ToString();
                case 14:
                    return result.AppendFormat("четырнадцать").ToString();
                case 15:
                    return result.AppendFormat("пятнадцать").ToString();
                case 16:
                    return result.AppendFormat("шестнадцать").ToString();
                case 17:
                    return result.AppendFormat("семнадцать").ToString();
                case 18:
                    return result.AppendFormat("восемнадцать").ToString();
                case 19:
                    return result.AppendFormat("девятнадцать").ToString();
            }
            switch(secondFigure)
            {
                case 2:
                    result.AppendFormat("двадцать ");
                    break;
                case 3:
                    result.AppendFormat("тридцать ");
                    break;
                case 4:
                    result.AppendFormat("сорок ");
                    break;
                case 5:
                    result.AppendFormat("пятьдесят ");
                    break;
                case 6:
                    result.AppendFormat("шестьдесят ");
                    break;
                case 7:
                    result.AppendFormat("семьдесят ");
                    break;
                case 8:
                    result.AppendFormat("восемьдесят ");
                    break;
            }


            return value.ToString();
        }
    }
}

