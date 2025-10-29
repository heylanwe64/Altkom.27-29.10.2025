using System.ComponentModel;

namespace DesignPatterns.Behavioral.Memento
{
    internal class AutoCaretaker<T> : Caretaker<T>, IDisposable where T : ICloneable, IRestorable<T>, INotifyPropertyChanging
    {
        public AutoCaretaker(T originator) : base(originator)
        {
            originator.PropertyChanging += Originator_PropertyChanging;
        }

        public void Dispose()
        {
            _originator.PropertyChanging -= Originator_PropertyChanging;
            base.Dispose();
        }

        private void Originator_PropertyChanging(object? sender, PropertyChangingEventArgs e)
        {
            SaveState();
        }

        public override void RestoreState()
        {
            base.RestoreState();
            base.RestoreState();
        }
    }
}
