namespace DesignPatterns.Structural.Proxy
{
    internal class Client
    {
        public static void Execute()
        {
            IDatabase database = new Database();

            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(250);
                _ = database.RequestAsync(i);
            }
            Console.ReadLine();

            for (int i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadLine();
            database.Dispose();
        }
    }
}
