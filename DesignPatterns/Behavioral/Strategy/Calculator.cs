namespace DesignPatterns.Behavioral.Strategy
{
    internal class Calculator
    {
        public ICalcStrategy? Strategy { get; set; }
        public float? Operate(float a, float b)
        {
            return Strategy?.Calc(a, b);
        }
    }
}
