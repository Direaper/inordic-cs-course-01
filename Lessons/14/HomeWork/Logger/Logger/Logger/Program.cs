using System;
using System.Collections.Generic;

namespace Logger
{

    class Program
    {

        static void Main(string[] args)
        {
             var clw = ConsoleLogWriter.GetInstance();
             clw.LogInfo("Test Information message");

            var flw = FileLogWriter.GetInstance();
            flw.LogInfo(@"D:\log.txt");
            flw.Dispose();

            
             
            

            // flw.LogInfo("Test information message");

            //var mlw = new MultipleLogWriter(new List<ILogWriter> { clw, flw });
            //clw.LogInfo("Test info mess");
            //flw.LogInfo("Test info mess");



        }
    }
}
