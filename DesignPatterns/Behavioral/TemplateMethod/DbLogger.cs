using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class DbLogger
    {
        public void Log(string message)
        {
            var dbLog = CreateDbLog(message);
            var service = OpenDbConnection();
            InsertLogMessage(service, dbLog);
            CloseDbConnection(service);
        }

        private void CloseDbConnection(DbService service)
        {
            service.Dispose();
        }

        private void InsertLogMessage(DbService service, DbLog dbLog)
        {
            service.Insert(dbLog);
        }

        private DbService OpenDbConnection()
        {
            Console.WriteLine("Connecting to Database.");
            return new DbService();
        }

        private DbLog CreateDbLog(string message)
        {
            Console.WriteLine("Serializing message");
            return new DbLog
            {
                Message = message,
                DateTime = DateTime.Now
            };
        }
    }
}
