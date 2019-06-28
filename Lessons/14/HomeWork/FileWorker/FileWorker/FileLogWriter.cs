using System;
using System.IO;

namespace FileWorker
{
  public  class FileLogWriter : AbstractLogWriter
    {
        private readonly string _filename;
        public FileLogWriter(string filename)
        {
            _filename = filename;
        }

        protected override void WriteLogMessage(string message)
        {
            File.AppendAllText(_filename, message);
        }
    }
         
}

 