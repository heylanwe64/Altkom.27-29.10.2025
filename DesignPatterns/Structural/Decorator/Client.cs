namespace DesignPatterns.Structural.Decorator
{
    internal class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();
                INotification notification = CreateNotificationStack();

                notification.Send(text);
            }
        }

        private static INotification CreateNotificationStack()
        {
            INotification notification = new SystemNotification();

            if (DateTime.Now.Second % 2 == 0)
                notification = new SmsDecorator(notification);
            if (DateTime.Now.Second % 3 == 0)
                notification = new EmailDecorator(notification);
            return notification;
        }
    }
}
