namespace DesignPatterns.Creational.ObjectPool
{
    internal class Client
    {
        public static void Execute()
        {
            var counter = 0;
            while (true)
            {
                if (counter >= 1000)
                {
                    Thread.Sleep(100);
                    continue;
                }

                var item = new Item();
                item.IsVisible = true;
                Interlocked.Increment(ref counter);

                Task.Delay(100).ContinueWith(x => { item.IsVisible = false; Interlocked.Decrement(ref counter); });
            }
        }
    }
}
