using System;

namespace FileWorker
{
    public class ConsoleLogWriter : AbstractLogWriter
    {
        private static ConsoleLogWriter value;

        private ConsoleLogWriter(string _value)
        {
            var value = _value;
        }

        public static ConsoleLogWriter GetValue()
        {
            return value ??
                (value = new ConsoleLogWriter());
        }

       protected override void WriteLogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void WriteLogMessage2(string message)
        {
            Console.WriteLine(message);
        }


    }
}
