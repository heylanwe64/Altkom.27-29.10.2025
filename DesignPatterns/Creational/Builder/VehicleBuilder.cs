namespace DesignPatterns.Creational.Builder
{
    internal class VehicleBuilder : VehicleBuilderFacade
    {

        public VehicleBuilder() : this(new Vehicle())
        {
        }

        public VehicleBuilder(Vehicle instance) : base(instance)
        {
        }

        public VehicleBuilder SetWheels(int wheels)
        {
            Instance.Wheels = wheels;
            return this;
        }

        public VehicleBuilder SetSeats(int seats)
        {
            Instance.Seats = seats;
            return this;    
        }

        public VehicleBuilder SetDoors(int doors)
        {
            Instance.Doors = doors;
            return this;    
        }

        public VehicleBuilder SetTrunkCapacity(int trunkCapacity)
        {
            Instance.TrunkCapacity = trunkCapacity;
            return this;
        }

        public VehicleBuilder SetEnginePower(int enginePower)
        {
            Instance.EnginePower = enginePower;
            return this;
        }

    }
}
