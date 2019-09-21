using System;

namespace Logger
{
    class ConsoleLogWriter : BaseLogWriter
    {
        protected override void LogSingleRecord(string message)
        {
            Console.WriteLine(message);
        }
    }
}
