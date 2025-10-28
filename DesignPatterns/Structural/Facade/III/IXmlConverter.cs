namespace DesignPatterns.Structural.Facade.III
{
    internal interface IXmlConverter
    {
        string ToXml<T>(T obj);
    }
}
