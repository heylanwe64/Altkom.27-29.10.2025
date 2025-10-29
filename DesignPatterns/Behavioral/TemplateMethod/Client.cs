namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class Client
    {
        public static void Execute()
        {
            var fileLogger = new FileLogger();
            fileLogger.Log("Message to Log in File.");
            Console.WriteLine();
            var emailLogger = new EmailLogger();
            emailLogger.Log("Message to Log via Email.");
            Console.WriteLine();
            var databaseLogger = new DbLogger();
            databaseLogger.Log("Message to Log in DB.");
        }
    }
}
