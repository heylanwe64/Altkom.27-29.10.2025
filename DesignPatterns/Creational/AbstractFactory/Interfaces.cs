namespace DesignPatterns.Creational.AbstractFactory
{
    internal interface ICar
    {
        public string Name { get; }
    }

    internal interface ISedan : ICar
    {
    }

    internal interface ISuv : ICar
    {
    }
}
