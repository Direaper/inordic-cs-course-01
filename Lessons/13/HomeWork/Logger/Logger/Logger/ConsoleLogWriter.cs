using System;

namespace Logger
{
    class ConsoleLogWriter : BaseLogWriter
    {
        public override void Dispose()
        {
         
        }

        public override void LogSingleRecord(LogMessageType logMessageType, string message)
        {
            Console.WriteLine(GetFormatedMessage(logMessageType, message));
        }
    }
}
