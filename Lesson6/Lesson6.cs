using System.Text;

namespace Lesson6
{
    public static class Lesson6
    {
        public static string Task1LongestWord(string phrase)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            var words=phrase.Split(delimiterChars);
            string wordMax=String.Empty;
            foreach (var word in words)
            {
                if (word.Length > wordMax.Length)
                    wordMax=word;
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
        public static string Task3Report(DateTime dateTime, decimal totalSellsCent, uint countGoodsSells)
        {
            var report = new StringBuilder($"Отчет о продажах за {dateTime.Month} {dateTime.Year}");
            


            return report.ToString();
        }
    }
}
