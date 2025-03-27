using System.Text;

namespace Lesson7
{
    interface IDisplayService
    {
        void Display(string data);
    }
    public static partial class Lesson7
    {        
        /// <summary>
        /// Урок 7. Задание 3. Массив в строку, необязательный параметр reverse
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="reverse"></param>
        /// <returns></returns>        
        public static  string PrintNumbers(int[] numbers,bool reverse = false)
        { 
            if (numbers==null)
                throw new ArgumentNullException(nameof(numbers));
            var result=new StringBuilder();
            if (reverse) Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                result.Append(number.ToString()).Append(" ");
            }
            return result.ToString();
        }        
        static void DisplayResult(string data, IDisplayService service) => service.Display(data);
    }
    class DisplayToConsole : IDisplayService
    {
        public void Display(string data) => Console.WriteLine(data);         
    }
}
