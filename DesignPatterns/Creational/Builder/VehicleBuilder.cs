namespace DesignPatterns.Creational.Builder
{
    internal class VehicleBuilder
    {
        private Vehicle Vehicle { get; } = new Vehicle();

        public void SetWheels(int wheels)
        {
            Vehicle.Wheels = wheels;
        }

        public void SetSeats(int seats)
        {
            Vehicle.Seats = seats;
        }

        public void SetDoors(int doors)
        {
            Vehicle.Doors = doors;
        }

        public void SetTrunkCapacity(int trunkCapacity)
        {
            Vehicle.TrunkCapacity = trunkCapacity;
        }

        public void SetEnginePower(int enginePower)
        {
            Vehicle.EnginePower = enginePower;
        }


        public Vehicle Build()
        {
            return Vehicle;
        }
    }
}
