namespace DesignPatterns.Behavioral.Strategy
{
    internal class DivideStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }
}
