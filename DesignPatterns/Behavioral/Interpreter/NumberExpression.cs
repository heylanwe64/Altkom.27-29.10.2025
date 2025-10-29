namespace DesignPatterns.Behavioral.Interpreter
{
    internal class NumberExpression : IExpression
    {
        private readonly string _number;
        public NumberExpression(string number)
        {
            _number = number;
        }

        public float Interpret()
        {
            return float.Parse(_number);
        }
    }
}
