namespace DesignPatterns.Behavioral.Observer
{
    internal class Subscription : IDisposable
    {
        private Action? _action;
        public Subscription(Action? action)
        {
            _action = action;
        }

        public void Dispose()
        {
            _action?.Invoke();
            _action = null;
        }
    }
}
