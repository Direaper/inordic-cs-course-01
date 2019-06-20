using System;

namespace FileWorker
{
    public class ConsoleLogWriter : AbstractLogWriter
    {
        protected override void WriteLogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
