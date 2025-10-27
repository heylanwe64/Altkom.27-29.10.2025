namespace DesignPatterns.Creational.Prototype
{
    internal class Client
    {
        public static void Execute()
        {
            var p0 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Address = new Address { City = "New York", Street = "5th Avenue" }
            };

            p0.Children.Add(new Person { FirstName = "Alice", LastName = "Doe", Age = 5 });
            p0.Children.Add(new Person { FirstName = "Bob", LastName = "Doe", Age = 3 });

            Console.WriteLine(p0);

            var p1 = p0.Clone() as Person;
            p1.FirstName = "Jane";

            Console.WriteLine(p1);

            p1.Children.Add(new Person { FirstName = "Charlie", LastName = "Doe", Age = 1 });

            p0.Address.Street = "Madison Avenue";


            Console.WriteLine(p0);
            Console.WriteLine(p1);
        }
    }
}
