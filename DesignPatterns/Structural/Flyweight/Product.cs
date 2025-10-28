namespace DesignPatterns.Structural.Flyweight
{
    internal class Product
    {
        /*public string Manufacturer { get => Flyweight.Manufacturer; set => Flyweight.Manufacturer = value; }
        public byte[] Logo { get => Flyweight.Logo; set => Flyweight.Logo = value; }
        public string Name { get => Flyweight.Name; set => Flyweight.Name = value; }
        public string Description { get => Flyweight.Description; set => Flyweight.Description = value; }
        public float Weight { get => Flyweight.Weight; set => Flyweight.Weight = value; }*/
        public string Manufacturer { get => Flyweight.Manufacturer; set => SetValue(x => x.Manufacturer = value); }
        public byte[] Logo { get => Flyweight.Logo; set => SetValue(x => x.Logo = value); }
        public string Name { get => Flyweight.Name; set => SetValue(x => x.Name = value); }
        public string Description { get => Flyweight.Description; set => SetValue(x => x.Description = value); }
        public float Weight { get => Flyweight.Weight; set => SetValue(x => x.Weight = value); }

        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public ProductFlyweight Flyweight { get; set; } = new ProductFlyweight();

        private void SetValue(Action<ProductFlyweight> action)
        {
            var clone = (ProductFlyweight)Flyweight.Clone();
            action(clone);
            Flyweight = FlyweightFactory.Instance.GetFlyweight(clone);
        }

        public void ShowShortInfo()
        {
            Flyweight.ShowShortInfo(this);
            //Console.WriteLine($"Name: {Name}, Manufacturer: {Manufacturer}, Weight: {Weight}, Expiration Date: {ExpirationDate.ToShortDateString()}, Description: {Description}");
        }
    }
}
