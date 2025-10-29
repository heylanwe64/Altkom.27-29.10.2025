namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class EmailLogger : Logger<Email, IDisposable>
    {
        protected override Email CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return new Email { Content = message };
        }

        protected override IDisposable GetService()
        {
            return null;
        }

        protected override void CloseService(IDisposable service)
        {
        }

        protected override void WriteLogMessage(IDisposable service, Email item)
        {
            Console.WriteLine("Sending Email with Log Message : " + item.Content);
        }
    }
}
