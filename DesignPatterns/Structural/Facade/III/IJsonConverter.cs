namespace DesignPatterns.Structural.Facade.III
{
    internal interface IJsonConverter
    {
        string ToJson<T>(T obj);
    }
}
