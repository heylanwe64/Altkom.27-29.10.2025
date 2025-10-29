namespace DesignPatterns.Behavioral.Strategy
{
    internal class AddStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            return a + b;
        }
    }
}
