using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    internal class FlyweightFactory
    {
        static FlyweightFactory()
        {
        }
        public static FlyweightFactory Instance { get; } = new FlyweightFactory();
        private FlyweightFactory()
        {
        }

        public void Initialize(params ProductFlyweight[] initialFlyweights)
        {
            foreach (var flyweight in initialFlyweights)
            {
                var key = GetKey(flyweight);
                if (!_flyweights.ContainsKey(key))
                {
                    _flyweights[key] = flyweight;
                }
            }
        }


        Dictionary<string, ProductFlyweight> _flyweights = [];
        private string GetKey(ProductFlyweight productFlyweight)
        {
            return $"{productFlyweight.Manufacturer}_{productFlyweight.Name}_{productFlyweight.Description}_{productFlyweight.Weight}";
        }

        public ProductFlyweight GetFlyweight(ProductFlyweight productFlyweight)
        {
            var key = GetKey(productFlyweight);

            if (_flyweights.TryGetValue(key, out var flyweight))
            {
                Console.WriteLine("Reusing existing flyweight.");
                return flyweight;
            }

            Console.WriteLine("Creating new flyweight.");
            _flyweights[key] = productFlyweight;
            return productFlyweight;
        }


        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"FlyweightFactory count: {_flyweights.Count}");
            foreach (var flyweight in _flyweights)
            {
                stringBuilder.AppendLine(flyweight.Key);
            }
            return stringBuilder.ToString();
        }

    }
}
