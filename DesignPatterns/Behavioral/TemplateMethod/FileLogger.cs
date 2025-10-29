
namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileLogger : Logger<string, FileService>
    {
        protected override FileService GetService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }

        protected override string CreateItem(string message)
        {
            return message;
        }

        protected override void WriteLogMessage(FileService service, string item)
        {
            service.Write(item);
        }
    }
}
