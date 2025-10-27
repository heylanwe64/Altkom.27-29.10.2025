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

    internal interface ISuvFactory
    {
        ISuv? CreateSuv(string segment);
    }

    internal interface ISedanFactory
    {
        ISedan? CreateSedan(string segment);
    }
}
