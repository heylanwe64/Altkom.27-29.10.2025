
namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileLogger
    {
        public void Log(object message)
        {
            var messageToLog = PrepareMessage(message);
            var service = OpenFile();
            WriteLogMessage(service, messageToLog);
            CloseFile(service);
        }

        private void CloseFile(FileService service)
        {
            service.Dispose();
        }

        private void WriteLogMessage(FileService service, string messageToLog)
        {
            service.Write(messageToLog);
        }

        private FileService OpenFile()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }

        private string PrepareMessage(object message)
        {
            return $"{DateTime.Now}: {message}"; 
        }
    }
}
