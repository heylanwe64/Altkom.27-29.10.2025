namespace DesignPatterns.Creational.Builder
{
    internal class VehicleBuilderFacade : BaseBuilder<Vehicle>

    {

        public VehicleBuilderFacade(Vehicle instance) : base(instance)
        {
        }

        public VehicleBuilder Technical => new VehicleBuilder(Instance);
        public VehicleProductionBuilder Production => new VehicleProductionBuilder(Instance);
    }
}
