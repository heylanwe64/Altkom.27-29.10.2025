using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    internal class BufferIterator<T> : IEnumerator<(T?, T?)>
    {
        public (T?, T?) Current { get; set; }

        object IEnumerator.Current => Current;


        private readonly IEnumerator<T> _enumerator;
        public BufferIterator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
            Reset();
        }


        public void Dispose()
        {
            _enumerator.Dispose();
            Current = default;
        }

        public bool MoveNext()
        {
            if(_enumerator.MoveNext())
            {
                Current = (Current.Item2, _enumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            Current = _enumerator.MoveNext() ? (default, _enumerator.Current) : default;
        }
    }
}
