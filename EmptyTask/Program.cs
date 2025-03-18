using System.Text;

public class Program
{    public static void Main(string[] args)
    {
        int i=ReverseDigitHelper(87, 0);
        i = i + 1;
    }
    private static int ReverseDigitHelper(int digit, int digitReverse)
    {
        if (digit == 0)
            return digitReverse;
        else
            return ReverseDigitHelper(digit / 10, digitReverse * 10 + digit % 10);
    }

}