namespace DesignPatterns.Behavioral.Observer
{
    internal abstract class Subscriber : IObserver<int>
    {
        public IDisposable? Subscription { private get; set; }
        public void OnCompleted()
        {
            Console.WriteLine($"{GetType().Name} otrzymał powiadomienie o zakończeniu");
            Subscription?.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name} otrzymał powiadomienie o błędzie: {error}");
        }

        public abstract void OnNext(int value);
    }
}
