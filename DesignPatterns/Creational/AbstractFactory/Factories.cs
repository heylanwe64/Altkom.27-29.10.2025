namespace DesignPatterns.Creational.AbstractFactory
{
    internal class HondaFactory : ISedanFactory, ISuvFactory
    {
        public ISedan? CreateSedan(string segment)
        {
            return segment switch
            {
                "Compact" => new HondaCompactSedan(),
                "Full" => new HondaFullSedan(),
                _ => null
            };
        }

        public ISuv? CreateSuv(string segment)
        {
            return segment switch
            {
                "Compact" => new HondaCompactSuv(),
                "Full" => new HondaFullSuv(),
                _ => null
            };
        }
    }

    internal class ToyotaFactory : ISedanFactory/*, ISuvFactory*/
    {
        public ISedan? CreateSedan(string segment)
        {
            return segment switch
            {
                "Compact" => new ToyotaCompactSedan(),
                "Full" => new ToyotaFullSedan(),
                _ => null
            };
        }
        /*public ISuv? CreateSuv(string segment)
        {
            return segment switch
            {
                "Compact" => new ToyotaCompactSuv(),
                "Full" => new ToyotaFullSuv(),
                _ => null
            };
        }*/
    }
}
