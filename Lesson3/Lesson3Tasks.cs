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
        /// <summary>
        /// Task 12. Return digit in string format
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SayNumber(int value)
        {
            if (100 > value || value > 999) return "Ошибка! Число вне диапазона 100-999.";
            string[] hundreds = { "","сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] secondTens = {"","одиннадцать", "двенадцать", "тринадцать", "четырнадцать","пятнадцать",
                "шестнадцать","семнадцать", "восемнадцать", "девятнадцать"};
            string[] tens = { "","", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семдесят", "восемдесят", "девяносто" };
            string[] regulars = { "","один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            var thirdDigit = value / 100;            
            var secondDigit = (value % 100 - value % 10)/10;
            var firstDigit = value % 10;
            var result = new StringBuilder();
            result.Append(hundreds[thirdDigit]).Append(" ");
            if (secondDigit == 1) return result.Append(secondTens[firstDigit]).ToString();
            return result.Append(tens[secondDigit]).Append(" ").Append(regulars[firstDigit]).ToString();
        }
    }
}

