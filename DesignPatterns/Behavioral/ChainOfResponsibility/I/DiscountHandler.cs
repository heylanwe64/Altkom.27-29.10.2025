namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandler : BaseHandler
    {
        public string Name { get; }

        private readonly float _maxDiscount;
        private readonly float _minPrice;

        public DiscountHandler(string name, float maxDiscount, float minPrice, IDiscountHandler? nextHandler = null) : base(nextHandler)
        {
            _maxDiscount = maxDiscount;
            _minPrice = minPrice;
            Name = name;
        }

        public override bool Discount(float value, float price)
        {
            if(value > _maxDiscount || price < _minPrice)
                return base.Discount(value, price);

            Console.WriteLine("Discount handled by " + Name);
            return true;
        }
    }
}
