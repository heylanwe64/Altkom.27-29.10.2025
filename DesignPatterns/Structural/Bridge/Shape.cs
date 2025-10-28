namespace DesignPatterns.Structural.Bridge
{
    internal abstract class Shape
    {
        public Color? Color { get; set; }

        public override string ToString()
        {
            return Color is null ? GetType().Name : $"{Color} {GetType().Name}";
        }
    }
}
