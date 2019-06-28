using System;
using System.IO;
using System.Text;

namespace FileWorker
{
    public abstract class AbstractLogWriter : ILogWriter
    {
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

        private void Log(LogLevel level, string message)
        {
            WriteLogMessage($"{DateTime.UtcNow:yyyy-MM-ddThh:mm:ss}+0000\t{level}\t{message} \n");

        }
        protected abstract void WriteLogMessage(string message);
    }   
}
