namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Order
    {
        private ICar? car;

        public string? CarName()
        {
            return car?.Name;
        }

        public void OrderSuv(ISuvFactory carFactory, string segment)
        {
            car = carFactory.CreateSuv(segment);
        }

        public void OrderSedan(ISedanFactory carFactory, string segment)
        {
            car = carFactory.CreateSedan(segment);
        }

        //Jakaś logika główna zamówienia
        //...
    }
}
