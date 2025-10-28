namespace DesignPatterns.Creational.Builder
{
    internal class VehicleProductionBuilder : VehicleBuilderFacade
    {
        public VehicleProductionBuilder() : this(new Vehicle())
        {
        }
        public VehicleProductionBuilder(Vehicle instance) : base(instance)
        {
        }

        public VehicleProductionBuilder SetManufacturer(string manufacturer)
        {
            Instance.Manufacturer = manufacturer;
            return this;
        }
        public VehicleProductionBuilder SetModel(string model)
        {
            Instance.Model = model;
            return this;
        }
        public VehicleProductionBuilder SetYear(int year)
        {
            Instance.Year = year;
            return this;
        }
        public VehicleProductionBuilder SetColor(string color)
        {
            Instance.Color = color;
            return this;
        }
    }
}
