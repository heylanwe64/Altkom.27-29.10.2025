namespace DesignPatterns.Structural.Decorator
{
    internal class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();
                INotification notification = new SystemNotification();

                notification.Send(text);
            }
        }
    }
}
