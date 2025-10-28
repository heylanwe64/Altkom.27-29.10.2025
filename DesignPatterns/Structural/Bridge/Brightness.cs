namespace DesignPatterns.Structural.Bridge
{
    internal abstract class Brightness
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
