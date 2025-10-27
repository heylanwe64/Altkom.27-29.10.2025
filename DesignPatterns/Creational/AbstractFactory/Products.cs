namespace DesignPatterns.Creational.AbstractFactory
{
    public class HondaCompactSuv : ISuv
    {
        public string Name => "Honda Compact SUV";
    }

    public class HondaCompactSedan : ISedan
    {
        public string Name => "Honda Compact Sedan";
    }

    public class HondaFullSuv : ISuv
    {
        public string Name => "Honda Full SUV";
    }

    public class HondaFullSedan : ISedan
    {
        public string Name => "Honda Full Sedan";
    }

    public class ToyotaCompactSuv : ISuv
    {
        public string Name => "Toyota Compact SUV";
    }

    public class ToyotaCompactSedan : ISedan
    {
        public string Name => "Toyota Compact Sedan";
    }

    public class ToyotaFullSuv : ISuv
    {
        public string Name => "Toyota Full SUV";
    }

    public class ToyotaFullSedan : ISedan
    {
        public string Name => "Toyota Full Sedan";
    }
}
