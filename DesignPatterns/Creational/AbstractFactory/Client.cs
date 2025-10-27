namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Client
    {
        public static void Execute()
        {
            var order = new Order();

            order.MakeOrder("Honda", "Compact", "Suv");
            Console.WriteLine("Ordered: " + order.CarName());

            order.MakeOrder("Honda", "Full", "Sedan");
            Console.WriteLine("Ordered: " + order.CarName());

            order.MakeOrder("Toyota", "Compact", "Suv");
            Console.WriteLine("Ordered: " + order.CarName());
        }
    }
}
