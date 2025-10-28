namespace DesignPatterns.Structural.Flyweight
{
    internal class Client
    {
        public static void Execute()
        {
            Console.WriteLine(FlyweightFactory.Instance);

            var product1 = new Product()
            {
                Manufacturer = "Acme Corp",
                Logo = new byte[] { 0x20, 0x20, 0x20 },
                Name = "SuperWidget",
                Description = "A top-notch widget for all your widgeting needs.",
                Weight = 1.5f,
                ProductionDate = new DateTime(2024, 1, 15),
                ExpirationDate = new DateTime(2026, 1, 15)
            };

            //product1.Flyweight = FlyweightFactory.Instance.GetFlyweight(product1.Flyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            var product11 = new Product() {
                Manufacturer = "Acme Corp",
                Logo = new byte[] { 0x20, 0x20, 0x20 },
                Name = "SuperWidget",
                Description = "A top-notch widget for all your widgeting needs.",
                Weight = 1.5f,
                ProductionDate = new DateTime(2024, 2, 20),
                ExpirationDate = new DateTime(2026, 2, 20)
            };

            //product11.Flyweight = FlyweightFactory.Instance.GetFlyweight(product11.Flyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            var product12 = new Product() {
                Manufacturer = "Acme Corp",
                Logo = new byte[] { 0x20, 0x20, 0x20 },
                Name = "SuperWidget",
                Description = "A top-notch widget for all your widgeting needs.",
                Weight = 1.5f,
                ProductionDate = new DateTime(2024, 3, 25),
                ExpirationDate = new DateTime(2026, 3, 25)
            };

            //product12.Flyweight = FlyweightFactory.Instance.GetFlyweight(product12.Flyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            var product2 = new Product()
            {
                Manufacturer = "Global Industries",
                Logo = new byte[] { 0x30, 0x30, 0x30 },
                Name = "MegaGadget",
                Description = "An advanced gadget for tech enthusiasts.",
                Weight = 2.3f,
                ProductionDate = new DateTime(2024, 2, 10),
                ExpirationDate = new DateTime(2027, 2, 10)
            };

            //product2.Flyweight = FlyweightFactory.Instance.GetFlyweight(product2.Flyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            product2.Description = "An advanced gadget for tech enthusiasts with enhanced features.";
            //var flyweightModified = (ProductFlyweight)product2.Flyweight.Clone();
            //flyweightModified.Description = "An advanced gadget for tech enthusiasts with enhanced features.";
            //product2.Flyweight = FlyweightFactory.Instance.GetFlyweight(flyweightModified);

            var product21 = new Product() { 
                Manufacturer = "Global Industries",
                Logo = new byte[] { 0x30, 0x30, 0x30 },
                Name = "MegaGadget",
                Description = "An advanced gadget for tech enthusiasts.",
                Weight = 2.3f,
                ProductionDate = new DateTime(2024, 3, 15),
                ExpirationDate = new DateTime(2027, 3, 15)
            };


            //product21.Flyweight = FlyweightFactory.Instance.GetFlyweight(product21.Flyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            product1.ShowShortInfo();
            product11.ShowShortInfo();
            product12.ShowShortInfo();
            product2.ShowShortInfo();
            product21.ShowShortInfo();

            Console.ReadLine();
        }
    }
}
