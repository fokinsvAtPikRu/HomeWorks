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
            for (int left = 0, right = cleanedPhrase.Length - 1; left < right; left++, right--)
            {
                if (cleanedPhrase[left] != cleanedPhrase[right])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
