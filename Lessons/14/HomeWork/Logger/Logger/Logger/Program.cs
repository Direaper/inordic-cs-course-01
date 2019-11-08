using System;
using System.Collections.Generic;

namespace Logger
{

    class Program
    {

        static void Main(string[] args)
        {
            // var clw = ConsoleLogWriter.GetInstance();
            // clw.LogInfo("Test Information message");

            //var flw = FileLogWriter.GetInstance();
            //flw.LogInfo(@"D:\log.txt");
            //flw.Dispose();
            
            var mlw = MultipleLogWriter.GetInstatance();
            mlw.LogInfo("sdsd");
            mlw.Dispose();
            


        }
    }
}
