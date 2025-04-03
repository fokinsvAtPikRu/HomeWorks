namespace Lesson8
{
    public class Lesson8Task1
    {
        public enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        public static double Calculate(double op1, double op2, Operation action)
        {
            double result = 0;
            switch (action)
            {
                case Operation.Add:
                    result = op1+op2;
                    break;
                    case Operation.Subtract:
                    result = op1-op2;
                    break;
                    case Operation.Multiply:
                    result = op1*op2;
                    break;
                    case Operation.Divide:
                    if (op2 == 0)
                        throw new DivideByZeroException("Деление на ноль!");
                    result = op2/op1;
                    break;
            }
            return result;
        }
    }
}
