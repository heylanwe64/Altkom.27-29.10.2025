namespace DesignPatterns.Structural.Decorator
{
    internal class SystemNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("System Notification: {0}", message);
        }
    }
}
