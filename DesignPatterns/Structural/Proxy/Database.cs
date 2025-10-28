namespace DesignPatterns.Structural.Proxy
{
    internal class Database : IDatabase
    {
        public const int MAX_REQUESTS = 5;

        public Database()
        {
            Console.WriteLine("Database connection established.");
        }

        public void Dispose()
        {
            Console.WriteLine("Database connection closed.");
        }

        private int _requestCounter = 0;
        public async Task RequestAsync(int @int)
        {
            if (_requestCounter >= MAX_REQUESTS)
            {
                Console.WriteLine($"Maximum request limit reached. Cannot process request {@int}");
                return;
            }

            Interlocked.Increment(ref _requestCounter);
            await Task.Delay(Random.Shared.Next(1000, 2500)); // Simulate database processing time
            Console.WriteLine($"Database processed request {@int}");
            Interlocked.Decrement(ref _requestCounter);
        }
    }
}
