namespace DesignPatterns.Behavioral.Visitor.II
{
    internal class Cart : Basket
    {
        public override void Add(Product product)
        {
            Console.WriteLine("Produkt w wózku");
        }
        public override void Add(BoxedProduct product)
        {
            Console.WriteLine("Karton produktu w wózku");
        }
    }
}
