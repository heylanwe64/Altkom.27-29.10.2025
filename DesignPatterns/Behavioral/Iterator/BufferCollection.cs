namespace DesignPatterns.Behavioral.Iterator
{
    internal class BufferCollection<T> : IEnumerable<(T?, T?)>
    {
        private readonly IEnumerable<T> _collection;
        public BufferCollection(IEnumerable<T> collection)
        {
            _collection = collection;
        }
        public IEnumerator<(T?, T?)> GetEnumerator()
        {
            return new BufferIterator<T>(_collection.GetEnumerator());
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        } 
    }
}
