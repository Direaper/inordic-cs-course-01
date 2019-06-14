using System;

namespace FileWorker
{
    public class MultipleLogWriter : AbstractLogWriter
    {
        public MultipleLogWriter(ConsoleLogWriter mes1, FileLogWriter mes2)
        {
           
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var mes2 = new FileLogWriter("info");
            mes2.LogInfo("message213");
            var mes = new ConsoleLogWriter("LOL");
            mes.LogInfo("ALARM");
             

             
            


            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
