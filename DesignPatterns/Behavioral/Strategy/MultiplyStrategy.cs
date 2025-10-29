namespace DesignPatterns.Behavioral.Strategy
{
    internal class MultiplyStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            return a * b;
        }
    }
}
