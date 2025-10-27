namespace DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);
            Console.WriteLine(vehicle);

            var builder = new VehicleBuilder();
            builder.SetWheels(4);
            builder.SetSeats(5);
            builder.SetDoors(4);
            builder.SetTrunkCapacity(500);
            builder.SetEnginePower(100);
            var vehicle1 = builder.Build();

            builder.SetEnginePower(150);
            var vehicle2 = builder.Build();

            Console.WriteLine(vehicle1);
            Console.WriteLine(vehicle2);

            vehicle = new VehicleBuilder()
                 .SetWheels(4)
                .SetSeats(5)
                .SetDoors(4)
                .SetTrunkCapacity(500)
                .SetEnginePower(100)
                .Build();

            Console.WriteLine(vehicle);

            vehicle = new Vehicle() { Doors = 4, EnginePower = 100, Seats = 5, TrunkCapacity = 500, Wheels = 4 };
            Console.WriteLine(vehicle);
        }
    }
}
