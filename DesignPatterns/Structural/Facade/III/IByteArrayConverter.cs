namespace DesignPatterns.Structural.Facade.III
{
    internal interface IByteArrayConverter
    {
        byte[] ToByteArray<T>(T obj);
    }
}
