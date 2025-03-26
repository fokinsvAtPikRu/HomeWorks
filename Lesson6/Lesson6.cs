using System.Text;
using System.Text.RegularExpressions;

namespace Lesson6
{
    public static class Lesson6
    {
        public static string Task1LongestWord(string phrase)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            var words = phrase.Split(delimiterChars);
            string wordMax = String.Empty;
            foreach (var word in words)
            {
                if (word.Length > wordMax.Length)
                    wordMax = word;
            }
            return wordMax;
        }

        public static bool Task2IsPalindrom(string phrase)
        {
            string cleanedPhrase = phrase.Replace(" ", "").ToLower();
            // самая короткая реализация
            // return cleanedPhrase.Equals(cleanedPhrase.Reverse());
            for (int left = 0, right = cleanedPhrase.Length - 1; left < right; left++, right--)
            {
                if (cleanedPhrase[left] != cleanedPhrase[right])
                {
                    return false;
                }
            }
            return true;
        }
        public static string Task3Report(DateTime date, decimal totalSells, uint countGoodsSells)
        {
            double averageProductPrice = (double)totalSells / countGoodsSells;
            var report = new StringBuilder(new string('-', 60));
            report.Append("\n");
            report.Append($"Отчет о продажах за {date.ToString("MMMM")} {date.Year}");
            report.Append("\n");
            report.Append('-', 60);
            report.Append("\n");
            report.Append($"Общая сумма продаж: {totalSells:0,0.00} руб \n");
            report.Append($"Количество проданных товаров: {countGoodsSells} шт \n");
            report.Append($"Средняя стоимость товаров - {averageProductPrice:N2} руб/шт \n");
            report.Append('-', 60);
            return report.ToString();
        }
        public static string Task4StringBuilder(string name, int age, string city) =>
            new StringBuilder().Append($"Имя: {name}, ").Append($"Возраст: {age}, ").Append($"Город: {city}").ToString();

        public static bool Task5IsValidPhoneNumber(string phoneNumber)
        {
            var phoneRegex = new Regex(@"^\+\d\(\d{3}\)\d{3}-\d{2}-\d{2}$");
            return phoneRegex.IsMatch(phoneNumber);
        }
        public static bool Task6IsValidPassword(string password)
        {
            var phoneRegex = new Regex(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[!#;%:?*]).{14}$");
            return phoneRegex.IsMatch(password);
        }
    }
}
