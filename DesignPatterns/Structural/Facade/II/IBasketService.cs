namespace DesignPatterns.Structural.Facade.II
{
    internal interface IBasketService
    {
        void AddProduct(int productId, float price);
        float GetTotalPrice();
        int GetId();
    }
}
