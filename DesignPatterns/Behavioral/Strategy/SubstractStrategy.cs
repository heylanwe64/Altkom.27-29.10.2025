namespace DesignPatterns.Behavioral.Strategy
{
    internal class SubstractStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            return a - b;
        }
    }
}
