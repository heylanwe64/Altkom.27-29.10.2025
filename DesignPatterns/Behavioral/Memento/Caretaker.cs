namespace DesignPatterns.Behavioral.Memento
{
    internal class Caretaker<T> : IDisposable where T : ICloneable, IRestorable<T>
    {
        private ICollection<Memento<T>> _mementos = [];
        protected T _originator;

        public Caretaker(T originator)
        {
            _originator = originator;
        }

        public void SaveState()
        {
            var memento = new Memento<T>(_originator);
            _mementos.Add(memento);
            Console.WriteLine($"Caretaker: snapshot {memento.DateTime}");
        }


        public void RestoreState(DateTime dateTime)
        {
            var memento = _mementos.LastOrDefault(x => x.DateTime <= dateTime);
            RestoreState(memento);
        }

        public virtual void RestoreState()
        {
            var memento = _mementos.LastOrDefault();
            _mementos.Remove(memento);
            RestoreState(memento);
        }

        private void RestoreState(Memento<T>? memento)
        {
            if (memento != null)
            {
                _originator.RestoreState(memento.GetState());
                Console.WriteLine($"Caretaker: restored {memento.DateTime}");
            }
        }

        public void Dispose()
        {
            _mementos.Clear();
            _originator = default!;
        }
    }
}
