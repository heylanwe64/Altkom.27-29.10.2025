namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Client
    {
        public static void Execute()
        {
            var order = new Order();

            order.OrderSuv(new HondaFactory(), "Compact");
            Console.WriteLine("Ordered: " + order.CarName());

            order.OrderSedan(new HondaFactory(), "Full");
            Console.WriteLine("Ordered: " + order.CarName());

            order.OrderSedan(new ToyotaFactory(), "Compact");
            Console.WriteLine("Ordered: " + order.CarName());
        }
    }
}
