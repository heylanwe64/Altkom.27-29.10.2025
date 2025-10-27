namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Order
    {
        private ICar? car;

        public string? CarName()
        {
            return car?.Name;
        }

        public void MakeOrder(string manufacturer, string type, string segment)
        {
            switch (manufacturer)
            {
                case "Honda":
                    car = type switch
                    {
                        "Compact" => segment switch
                        {
                            "Suv" => new HondaCompactSuv(),
                            "Sedan" => new HondaCompactSedan(),
                            _ => null
                        },
                        "Full" => segment switch
                        {
                            "Suv" => new HondaFullSuv(),
                            "Sedan" => new HondaFullSedan(),
                            _ => null
                        },
                        _ => null
                    };
                    break;
                case "Toyota":
                    car = type switch
                    {
                        "Compact" => segment switch
                        {
                            "Suv" => new ToyotaCompactSuv(),
                            "Sedan" => new ToyotaCompactSedan(),
                            _ => null
                        },
                        "Full" => segment switch
                        {
                            "Suv" => new ToyotaFullSuv(),
                            "Sedan" => new ToyotaFullSedan(),
                            _ => null
                        },
                        _ => null
                    };
                    break;
                default:
                    car = null;
                    break;
            }
        }

        //Jakaś logika główna zamówienia
        //...
    }
}
