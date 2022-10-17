using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class DatabaseLoggerService : ILoggerService
    {

        public void Log()
        {
            Console.WriteLine("Database'e Loglandı");        }
    }

    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosya'ya Loglandı");
        }
    }
}
