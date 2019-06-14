using System;

namespace FileWorker
{
    public class ConsoleLogWriter : AbstractLogWriter
    {
        public ConsoleLogWriter(string message)
        {
             
        }
        public override void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now} \n {message.GetType()}\n {message}");
        }

        public override void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now} \n {message.GetType()}\n {message}");
        }

        public override void LogError(string message)
        {
            Console.WriteLine($"{DateTimeOffset.Now} \n {message.GetType()}\n {message}");
        }
    }
}
