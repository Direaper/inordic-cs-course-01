using System;

namespace FileWorker
{
    public class ConsoleLogWriter : ILogWriter
    {
        private void Log(LogLevel level, string message)
        {
            Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss}+0000\t{1}\t{2}", DateTime.UtcNow, level, message);
        }

        public void LogInfo(string message)
        {
            Log(LogLevel.Info, message);
        }

        public void LogWarning(string message)
        {
            Log(LogLevel.Warning, message);
        }

        public void LogError(string message)
        {
            Log(LogLevel.Error, message);
        }
    }
}
