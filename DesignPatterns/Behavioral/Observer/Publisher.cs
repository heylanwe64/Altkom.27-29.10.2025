namespace DesignPatterns.Behavioral.Observer
{
    internal class Publisher : IObservable<int>, IDisposable
    {
        private ICollection<IObserver<int>> _observers = [];

        public IDisposable Subscribe(IObserver<int> observer)
        {
            Console.WriteLine($"{observer.GetType().Name} podłączył się");
            _observers.Add(observer);

            return new Subscription(() =>
            {
                _observers.Remove(observer);
            });
        }

        public int Index { get; set; }
        public async Task Work()
        {
            for (int i = 0; i < 15; i++)
            {
                await Task.Delay(1000);
                var second = DateTime.Now.Second;
                if (second % 3 == 0)
                {
                    Index = second;
                    Notify();
                }
            }
        }

        private void Notify()
        {
            if (Index == 0)
            {
                foreach (var item in _observers.ToList())
                {
                    item.OnError(new IndexOutOfRangeException(Index.ToString()));
                }
            }
            else
            {
                foreach (var item in _observers.ToList())
                {
                    item.OnNext(Index);
                    //Task.Run(() => item.OnNext(Index));
                }
            }
        }

        public void Dispose()
        {
            foreach (var item in _observers.ToList())
            {
                item.OnCompleted();
            }
        }
    }
}
