using System;

namespace Logger
{
    class ConsoleLogWriter : BaseLogWriter
    {
       private static ConsoleLogWriter _consoleLogWriter;
        private ConsoleLogWriter() { }
        public override void Dispose() { }

        public override void LogSingleRecord(LogMessageType logMessageType, string message)
        {
            Console.WriteLine(GetFormatedMessage(logMessageType, message));
        }

        public static ConsoleLogWriter GetInstance()
        {
            if(_consoleLogWriter == null)
            _consoleLogWriter = new ConsoleLogWriter();

            return _consoleLogWriter;
        }

    }
}
