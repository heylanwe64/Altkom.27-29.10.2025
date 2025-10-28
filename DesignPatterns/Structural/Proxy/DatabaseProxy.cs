namespace DesignPatterns.Structural.Proxy
{
    internal class DatabaseProxy : IDatabase
    {
        private IDatabase? _database;
        public DatabaseProxy(IDatabase database)
        {
            _database = database;
        }

        private Func<IDatabase>? _openConnection;
        public DatabaseProxy(Func<IDatabase> openConnection)
        {
            _openConnection = openConnection;
        }

        public void Dispose()
        {
            _database?.Dispose();
            _database = null;
        }

        public const int MAX_REQUESTS = 4;
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(MAX_REQUESTS);

        public async Task RequestAsync(int @int)
        {
            await _semaphore.WaitAsync();
            try
            {
                if (_database is null && _openConnection is not null)
                {
                    _database = _openConnection();
                }
                
                if(_database is null)
                {
                    Console.WriteLine("Database connection is not available.");
                    return;
                }

                await _database.RequestAsync(@int);
            }
            finally
            {
                _semaphore.Release();
            }

            if(_semaphore.CurrentCount == MAX_REQUESTS && _openConnection is not null)
            {
                Dispose();
            }
        }
    }
}
