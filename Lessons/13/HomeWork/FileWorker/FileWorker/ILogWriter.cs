﻿namespace FileWorker
{
    public interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string message);
    }
}