namespace DesignPatterns.Structural.Facade.II
{
    internal interface IPaymentService
    {
        void Pay(int basketId, float amount);
    }
}
