using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FileWorker
{
    public class MultipleLogWriter : ILogWriter
    {
        private readonly IEnumerable<ILogWriter> _writers;

        public MultipleLogWriter(params ILogWriter[] writers)
        {
            _writers = writers ?? Enumerable.Empty<ILogWriter>();
        }

        public void LogInfo(string message)
        {
            foreach (var writer in _writers)
                {
                    writer.LogInfo(message);
                }
        }

        public void LogWarning(string message)
        {
            foreach (var writer in _writers)
            {
                writer.LogWarning(message);
            }
        }

        public void LogError(string message)
        {
            foreach (var writer in _writers)
            {
                writer.LogError(message);
            }
        }

        private void log(LogLevel level, string message)
        {
            Console.WriteLine("{0:yyyy-MM-ddThh:mm:ss}+0000\t{1}\t{2}", DateTime.UtcNow, level, message);
        }

    }
}
