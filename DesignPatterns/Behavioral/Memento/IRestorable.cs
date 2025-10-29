namespace DesignPatterns.Behavioral.Memento
{
    internal interface IRestorable<T>
    {
        void RestoreState(T state);
    }
}
