namespace DesignPatterns.Creational.Prototype
{
    internal class Person : ICloneable
    {
        public Person? Parent { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address? Address { get; set; }

        public ICollection<Person> Children { get; set; } = new List<Person>();

        //pośrednie klonowanie - płytkie klonowanie z ręcznym klonowaniem obiektów referencyjnych
        //ręczne dostosowanie głbokości klonowania - najczęściej wykorzystywane
        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = Address?.Clone();
            clone.Children = Children.ToList();
            return clone;
        }

        //głębokie klonowanie - kopiuje również obiekty referencyjne
        //może doprowadzić do problemów z cyklicznymi referencjami
        public object DeepClone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = Address?.Clone();
            clone.Children = [.. Children.Select(c => (Person)c.DeepClone())];
            clone.Parent = (Person)Parent?.DeepClone();
            return clone;
        }

        //płytkie klonowanie - kopiuje tylko wartości pól, a nie obiekty referencyjne
        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            var children = string.Join(", ", Children.Select(c => c.FirstName));
            return $"{FirstName} {LastName}, Age: {Age}, Address: {Address?.Street}, {Address?.City}, Children: {children}";
        }
    }
}
