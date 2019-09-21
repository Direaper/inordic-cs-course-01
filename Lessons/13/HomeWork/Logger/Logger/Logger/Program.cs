using System;

namespace Logger
{

    //class FileLogWriter : BaseLogWriter
    //{

    //}

    class Program
    {

        static void Main(string[] args)
        {
            ConsoleLogWriter lw = new ConsoleLogWriter();
            lw.LogError("test");
            Console.ReadKey();
        }
    }
}
