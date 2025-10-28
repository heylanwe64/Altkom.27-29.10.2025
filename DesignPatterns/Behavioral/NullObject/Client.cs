namespace DesignPatterns.Behavioral.NullObject
{
    internal class Client
    {
        public static void Execute()
        {
            var objects = new AbstractObject[] { new RealObject(), new NullObject() };

            while (true)
            {
                var value = Random.Shared.Next(0, objects.Length);

                Console.ReadLine();

                var item = objects[value];

                /*if (item is null)
                    continue;*/

                item.Method1();
                item.Method2();
                item.Method3();
            }
        }
    }
}
