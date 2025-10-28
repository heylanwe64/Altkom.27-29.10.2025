namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Container : Component
    {
        protected ICollection<Component> Content { get; } = [];

        public void Add(Component component)
        {
            component.Parent = this;
            Content.Add(component);
        }
    }
}
