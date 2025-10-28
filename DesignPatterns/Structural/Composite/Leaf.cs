namespace DesignPatterns.Structural.Composite
{
    internal abstract class Leaf : IComponent
    {
        public string Name => GetType().Name;
        public float Value { get; private set; }
        public Leaf(float value)
        {
            Value = value;
        }

        public float GetValue()
        {
            Console.WriteLine("\tValue of {0} is {1}", Name, Value);
            return Value;
        }
    }
}
