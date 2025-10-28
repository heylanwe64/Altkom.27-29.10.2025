namespace DesignPatterns.Creational.ObjectPool
{
    internal class Item
    {
        public bool IsVisible { get; set; }
        public byte[] Content { get; } = new byte[1024 * 1024]; // 1 MB
    }
}
