namespace DesignPatterns.Creational.Prototype
{
    public class Address : ICloneable<Address>
    {
        public string Street { get; set; }
        public string City { get; set; }

        public Address Clone()
        {
            return (Address) MemberwiseClone();
        }
    }
}