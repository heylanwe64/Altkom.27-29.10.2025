namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class DbLogger : Logger<DbLog, DbService>
    {
        protected override DbService GetService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DbService();
        }

        protected override DbLog CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return new DbLog
            {
                Message = message,
                DateTime = DateTime.Now
            };
        }

        protected override void WriteLogMessage(DbService service, DbLog item)
        {
            service.Insert(item);
        }

        protected override string PrepareMessage(string message)
        {
            return message;
        }

    }
}
