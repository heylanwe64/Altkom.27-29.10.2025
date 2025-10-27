namespace DesignPatterns.Creational.Builder
{
    internal class VehicleBuilder
    {
        private Vehicle Vehicle { get; } = new Vehicle();

        public VehicleBuilder SetWheels(int wheels)
        {
            Vehicle.Wheels = wheels;
            return this;
        }

        public VehicleBuilder SetSeats(int seats)
        {
            Vehicle.Seats = seats;
            return this;    
        }

        public VehicleBuilder SetDoors(int doors)
        {
            Vehicle.Doors = doors;
            return this;    
        }

        public VehicleBuilder SetTrunkCapacity(int trunkCapacity)
        {
            Vehicle.TrunkCapacity = trunkCapacity;
            return this;
        }

        public VehicleBuilder SetEnginePower(int enginePower)
        {
            Vehicle.EnginePower = enginePower;
            return this;
        }


        public Vehicle Build()
        {
            return Vehicle;
        }
    }
}
