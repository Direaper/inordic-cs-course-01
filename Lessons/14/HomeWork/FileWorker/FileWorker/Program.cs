using System;

namespace FileWorker
{


    class Program
    {
        static void Main(string[] args)
        {
            var logger = new MultipleLogWriter(
                new ConsoleLogWriter.WriteLogMessage2(),
                
            new FileLogWriter("C:\\log\\file.log")
            );

            logger.LogInfo("INFO MESSAGE");
            logger.LogWarning("WARNING MESSAGE");
            logger.LogError("ERROR MESSAGE");
           
            Console.ReadKey();

        }
    }
}
