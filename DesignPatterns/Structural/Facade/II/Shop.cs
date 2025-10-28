namespace DesignPatterns.Structural.Facade.II
{
    internal class Shop
    {
        IBasketService _basketService;
        IProductsService _productsService;
        IPaymentService _paymentService;

        public Shop(IBasketService basketService, IProductsService productsService, IPaymentService paymentService)
        {
            _basketService = basketService;
            _productsService = productsService;
            _paymentService = paymentService;
        }

        public void PurchaseProducts(int[] productIds)
        {
            foreach (var productId in productIds)
            {
                var price = _productsService.GetPrice(productId);
                _basketService.AddProduct(productId, price);
            }
            var totalPrice = _basketService.GetTotalPrice();
            _paymentService.Pay(_basketService.GetId(), totalPrice);
        }
    }
}
