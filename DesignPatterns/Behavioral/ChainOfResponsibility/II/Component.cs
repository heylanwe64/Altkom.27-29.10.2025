namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal abstract class Component
    {

        public string Name { get; set; } = string.Empty;

        public Component? Parent { get; set; }

        public void Click()
        {
            Click(false);
        }

        protected virtual void Click(bool handled)
        {
            Parent?.Click(handled);
        }
    }
}
