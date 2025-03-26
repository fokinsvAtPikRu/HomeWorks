using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    interface IDisplayService
    {
        void Display(string data);
    }
    public static partial class Lesson7
    {
        public interface IDisplayService
        {
            void Display(string data);
        }
        public static  string PrintNumbers(int[] numbers,bool reverse = false)
        { 
            var result=new StringBuilder();
            if (reverse) numbers.Reverse();
            foreach (var number in numbers)
            {
                result.Append(number.ToString()).Append(" ");
            }
            return result.ToString();
        }        
        public static void DisplayResult(string data, IDisplayService service) => service.Display(data);
    }
    class DisplayToConsole : IDisplayService
    {
        public void Display(string data) => Console.WriteLine(data); 
        
    }
}
