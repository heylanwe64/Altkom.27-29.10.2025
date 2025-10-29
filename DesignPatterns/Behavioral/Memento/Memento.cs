namespace DesignPatterns.Behavioral.Memento
{
    internal class Memento<T> where T : ICloneable
    {
        private readonly T _state;
        public DateTime DateTime { get; }

        public Memento(T state)
        {
            _state = (T)state.Clone();
            DateTime = DateTime.Now;
        }

        public T GetState()
        {
            return (T)_state.Clone();
        }
    }
}
