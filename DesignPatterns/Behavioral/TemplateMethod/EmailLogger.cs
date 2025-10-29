namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class EmailLogger
    {
        public void Log(string message)
        {
            var messageToLog = CreateEmail(message);
            SendLogToEmail(messageToLog);
        }

        private Email CreateEmail(string message)
        {
            Console.WriteLine("Serializing message");
            return new Email { Content = message };
        }
        private void SendLogToEmail(Email email)
        {
            Console.WriteLine("Sending Email with Log Message : " + email.Content);
        }
    }
}
