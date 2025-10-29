namespace DesignPatterns.Behavioral.Strategy
{
    internal class Client
    {
        public static void Execute()
        {
            var context = new Calculator();
            while (true)
            {
                var line = Console.ReadLine();
                var split = line?.Split(' '); // 2 + 4
                if (split.Length < 3) continue;

                context.Strategy = GetStrategy(split[1]);

                if (context.Strategy is null)
                {
                    Console.WriteLine("Unknown operation");
                    continue;
                }

                if (float.TryParse(split[0], out var a) && float.TryParse(split[2], out var b))
                {
                    var result = context.Operate(a, b);
                    Console.WriteLine($"Result: {result}");

                    Console.WriteLine(GetFunc(split[1])(a, b));
                }
                else
                {
                    Console.WriteLine("Invalid numbers");
                }
            }
        }

        private static ICalcStrategy? GetStrategy(string v)
        {
            return v switch
            {
                "+" => new AddStrategy(),
                "-" => new SubstractStrategy(),
                "*" => new MultiplyStrategy(),
                "/" => new DivideStrategy(),
                _ => null
            };
        }

        private static Func<float, float, float> GetFunc(string v)
        {
            return v switch
            {
                "+" => (a, b) => a + b,
                "-" => (a, b) => a - b,
                "*" => (a, b) => a * b,
                "/" => (a, b) =>
                {
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                    return a / b;
                }
                ,
                _ => throw new InvalidOperationException("Unknown operation")
            };
        }
    }
}
