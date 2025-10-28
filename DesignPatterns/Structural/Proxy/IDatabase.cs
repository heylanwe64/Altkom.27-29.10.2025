namespace DesignPatterns.Structural.Proxy
{
    internal interface IDatabase : IDisposable
    {
        Task RequestAsync(int @int);
    }
}
