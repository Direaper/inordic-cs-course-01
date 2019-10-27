using System;

namespace Logger
{
    public interface ILogWriter: IDisposable
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);

        void LogSingleRecord(LogMessageType logMessageType, string message);

    }
}
