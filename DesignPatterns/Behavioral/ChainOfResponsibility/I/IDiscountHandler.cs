namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal interface IDiscountHandler
    {
        bool Discount(float value, float price);
    }
}
