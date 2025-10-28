using System.Diagnostics.Metrics;

namespace DesignPatterns.Creational.ObjectPool
{
    internal class Client
    {
        public static void Execute()
        {
            /*var counter = 0;
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
            }*/

            /*var objectPool = new ObjectPool<Item>(() => new Item(), 1000);
            while (true)
            {
                var item = objectPool.Acquire();
                if (item is null)
                {
                    Thread.Sleep(100);
                    continue;
                }

                item.IsVisible = true;

                Task.Delay(100).ContinueWith(x => { item.IsVisible = false; objectPool.Release(item); });
            }*/

            var objectPool = new ItemPool(1000);
            while (true)
            {
                var item = objectPool.Acquire();
                if (item is null)
                {
                    Thread.Sleep(100);
                    continue;
                }

                Task.Delay(100).ContinueWith(x => { item.IsVisible = false; });
            }
        }
    }
}
