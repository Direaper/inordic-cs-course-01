namespace FileWorker
{
  public  class FileLogWriter : ILogWriter
    {
        private readonly string _filename;
        public FileLogWriter(string filename)
        {
            _filename = filename;
        }

        public void LogInfo(string message)
        {

        }

        public void LogWarning(string message)
        {

        }

        public void LogError(string message)
        {

        }
 
    }
}
