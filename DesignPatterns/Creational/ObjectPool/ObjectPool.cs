using System.Collections.Concurrent;

namespace DesignPatterns.Creational.ObjectPool
{
    internal class ObjectPool<T>
    {
        private ConcurrentQueue<T> _queue;
        public ObjectPool(Func<T> objectGenerator, int initialCapacity)
        {
            _queue = new ConcurrentQueue<T>();
            for (int i = 0; i < initialCapacity; i++)
            {
                _queue.Enqueue(objectGenerator());
            }
        }

        public T? Acquire()
        {
            if (_queue.TryDequeue(out T? item))
            {
                return item;
            }
            return default;
        }

        public void Release(T item)
        {
            _queue.Enqueue(item);
        }
    }
}
