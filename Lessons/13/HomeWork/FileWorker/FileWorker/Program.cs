using System;

namespace FileWorker
{
    interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string message);        void LogError(string message); 
    }

    class FileLogWriter : ILogWriter
    {
        public FileLogWriter(string LogInfo , string LogWarning, string LogError) 
        {

        }
         public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now} \n {message.GetType()}\n {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now} \n {message.GetType()}\n {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.Now} \n {message.GetType()}\n {message}");
        }
    }


   public class ConsoleLogWriter : ILogWriter
    {
        public ConsoleLogWriter(string message)
        {
             
        }
        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now} \n {message.GetType()}\n {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now} \n {message.GetType()}\n {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"{DateTimeOffset.Now} \n {message.GetType()}\n {message}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var mes = new ConsoleLogWriter("LOL");
            mes.LogInfo("ALARM");

            Console.WriteLine(mes);
        }
    }
}
