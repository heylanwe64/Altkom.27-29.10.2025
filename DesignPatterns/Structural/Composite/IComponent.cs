namespace DesignPatterns.Structural.Composite
{
    internal interface IComponent
    {
        string Name { get; }
        float GetValue();
    }
}
