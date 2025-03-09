using System.Text;

public class Program
{
    public enum EvenAndOddElements // для результата первого задания
    {
        EvenIsMore,
        OddIsMore,
        Equal
    }
    public static void Main(string[] args)
    {
        IsNumberOfEvenElementsGreater(new int[] { 1, 2, 3 });
    }
    public static int FoldArrayValue(int[] array, int acc, Func<int, int, bool> f)              // свертка массива foreach
    {                                                                                          // для задач где не нужен  
        foreach (int element in array)                                                         // индекс элемента  
            if (f(element, acc)) acc++;
        return acc;
    }
    public static int CountOfEvenElements(int[] array) =>
            FoldArrayValue(array, 0, (element, acc) => element % 2 == 0 ? true : false);              // количество четных элементов

    public static int CountOfOddElements(int[] array) =>
            FoldArrayValue(array, 0, (element, acc) => element % 2 != 0 ? true : false);              // количество нечетных элементов
    public static EvenAndOddElements IsNumberOfEvenElementsGreater(int[] array)                      // метод выполняет 1 задание урока 5
    {
        int even = CountOfEvenElements(array);
        int odd = CountOfOddElements(array);
        return
            even > odd ? EvenAndOddElements.EvenIsMore :    // больше четных
            even < odd ? EvenAndOddElements.OddIsMore :     // больше нечетных 
            EvenAndOddElements.Equal;                                                                     // равное количество            
    }
}