namespace DesignPatterns.Creational.Prototype
{
    //pomocniczy interfejs generyczny do klonowania
    internal interface ICloneable<T>
    {
        T Clone();
    }
}
