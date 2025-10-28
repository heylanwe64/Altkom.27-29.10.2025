namespace DesignPatterns.Structural.Decorator
{
    internal abstract class BaseDecorator : INotification
    {
        private readonly INotification _notification;
        public BaseDecorator(INotification notification)
        {
            _notification = notification;
        }

        public void Send(string message)
        {
            _notification.Send(message);
            ExtraSend(message);
        }

        protected abstract void ExtraSend(string message);
    }
}
