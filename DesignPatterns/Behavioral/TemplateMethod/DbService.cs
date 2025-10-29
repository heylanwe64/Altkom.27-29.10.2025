namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class DbService : IDisposable
    {

        public void Insert(DbLog dbLog)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + dbLog.Message);
        }
        public void Dispose()
        {
            Console.WriteLine("Closing DB connection");
        }
    }
}
