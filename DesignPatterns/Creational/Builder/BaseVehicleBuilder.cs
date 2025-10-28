namespace DesignPatterns.Creational.Builder
{
    internal abstract class BaseBuilder<T> where T : ICloneable
    {
        protected T Instance { get; }
        protected BaseBuilder(T instance)
        {
            Instance = instance;
        }


        public T Build()
        {
            return (T)Instance.Clone();
        }
    }
}
