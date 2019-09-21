using System;

namespace Logger
{
    abstract class BaseLogWriter : ILogWriter
    {
        private string _logFormat = "{0:yyyy-MM-ddThh:mm:ss}+0000\t{1}\t{2}"; //поле, которое задает формат

        abstract protected void LogSingleRecord(string message); //абстрактный метод, который только принимает одну переменную
        private string GetFormatedMessage(LogMessageType logMessageType, string message)
        {
            return string.Format(_logFormat, DateTime.UtcNow, logMessageType, message);   //Создается реализация абстрактного метода, которая включает метот string.format, позволяющий передавать любое кол-во параметров)
        }
        public void LogError(string message)
        {
            LogSingleRecord(GetFormatedMessage(LogMessageType.Error, message));
        }

        public void LogInfo(string message)
        {
            LogSingleRecord(GetFormatedMessage(LogMessageType.Info, message));
        }

        public void LogWarning(string message)
        {
            LogSingleRecord(GetFormatedMessage(LogMessageType.Warning, message));
        }
    }
}
