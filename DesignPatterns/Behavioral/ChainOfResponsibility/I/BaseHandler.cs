namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal abstract class BaseHandler : IDiscountHandler
    {
        private readonly IDiscountHandler? _nextHandler;
        public BaseHandler(IDiscountHandler? nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual bool Discount(float value, float price)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Discount(value, price);
            }
            return false;
        }
    }
}
