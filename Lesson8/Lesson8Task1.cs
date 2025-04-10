namespace Lesson8
{
    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public class Lesson8Task1
    {        
        public static double Calculate(double op1, double op2, Operation action)
        {
            double result = 0;
            switch (action)
            {
                case Operation.Add:
                    result = op1 + op2;
                    break;
                case Operation.Subtract:
                    result = op1 - op2;
                    break;
                case Operation.Multiply:
                    result = op1 * op2;
                    break;
                case Operation.Divide:
                    result = op2 == 0 ? throw new DivideByZeroException("Деление на ноль!") : op1 / op2;
                    break;
            }
            return result;
        }
    }
}
