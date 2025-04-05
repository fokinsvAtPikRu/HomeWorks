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
            int startIndex = reverse ? numbers.Length - 1 : 0;
            int endIndex = reverse ? 0 : numbers.Length - 1;
            Func<int, int> iterator = reverse ? (x => x - 1) : (x => x + 1);
            for (int i = startIndex; reverse ? i >= endIndex : i <= endIndex; i = iterator(i))
            {
                result.Append(numbers[i].ToString()).Append(" ");
            }
            return result.ToString().Trim();
        }
        static void DisplayResult(string data, IDisplayService service) => service.Display(data);
    }
    class DisplayToConsole : IDisplayService
    {
        public void Display(string data) => Console.WriteLine(data);         
    }
}
