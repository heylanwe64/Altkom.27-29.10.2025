namespace DesignPatterns.Behavioral.Interpreter
{
    internal class Client
    {
        public static void Execute()
        {
            // Example expression: |5 + 3 - 10|

            IExpression expression = new AbsExpression(
                                        new MinusExpression(
                                            new PlusExpression(
                                                new NumberExpression("5"),
                                                new NumberExpression("3")
                                            ),
                                            new NumberExpression("10")
                                        )
                                     );

            float result = expression.Interpret();
            Console.WriteLine($"Result: {result}"); // Output: Result: 2
        }
    }
}
