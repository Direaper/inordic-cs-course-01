using System;
using System.IO;

namespace Logger

{
    class FileLogWriter : BaseLogWriter 
    {

        private StreamWriter _streamWriter;

        public FileLogWriter(string fileName = "C:\\Users\\jimac\\Desktop\\log.txt")
        {

            _streamWriter = new StreamWriter(
                File.Open(
                    fileName,
                    FileMode.OpenOrCreate,
                    FileAccess.ReadWrite,
                    FileShare.Read));
            _streamWriter.BaseStream.Seek(0, SeekOrigin.End);
        }

        public override void Dispose()
        {
            if (_streamWriter != null)
                _streamWriter.Dispose();
        }

        public override void LogSingleRecord(LogMessageType logMessageType, string message)
        {

            {
                _streamWriter.WriteLine(GetFormatedMessage( logMessageType, message));
            }
        }
    }
}
