namespace DesignPatterns.Structural.Composite
{
    internal class Client
    {
        public static void Execute()
        {
            var warehouse = new Warehouse();

            var shelf1 = new Shelf();
            var shelf2 = new Shelf();

            var box1 = new Box();
            var box2 = new Box();
            var box3 = new Box();
            var box4 = new Box();

            warehouse.Components.Add(shelf1);
            warehouse.Components.Add(shelf2);

            shelf1.Components.Add(box1);
            shelf2.Components.Add(box2);
            shelf2.Components.Add(box3);

            warehouse.Components.Add(box4);

            for (int i = 0; i < 10; i++)
            {
                box1.Components.Add(new Tea(1.5f * Random.Shared.NextSingle()));
                box2.Components.Add(new Toy(2.5f * Random.Shared.NextSingle()));
                box3.Components.Add(new Soda(3.5f * Random.Shared.NextSingle()));
            }

            for (int i = 0; i < 5; i++)
            {
                box4.Components.Add(new Tea(1.5f * Random.Shared.NextSingle()));
                box4.Components.Add(new Soda(3.5f * Random.Shared.NextSingle()));
            }

            shelf1.Components.Add(new Toy(5.5f));

            Console.WriteLine("Total value of warehouse: {0}", warehouse.GetValue());
            Console.WriteLine("----");
            Console.WriteLine("Total value of shelf1: {0}", shelf1.GetValue());

            Console.WriteLine("Total value of ???: {0}", warehouse.Components[2].GetValue());
        }
    }
}
