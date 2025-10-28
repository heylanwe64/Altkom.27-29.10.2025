namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Frame : Container
    {

        protected override void Click(bool handled)
        {
            Console.WriteLine($"{Name} flashed");
            base.Click(handled);
        }

    }
}
