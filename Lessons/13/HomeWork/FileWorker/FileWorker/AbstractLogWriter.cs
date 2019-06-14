using System;
using System.IO;
using System.Text;

namespace FileWorker
{
    public abstract class AbstractLogWriter : ILogWriter
    {
        public virtual void LogInfo(string message)
        {
            var text = $"{DateTime.Now} \n {message.GetType()}\n {message}";


            using (FileStream fstream = new FileStream(@"C:\log\log.txt", FileMode.OpenOrCreate))
            {

                byte[] input = Encoding.Default.GetBytes(text);
                fstream.Write(input, 0, text.Length);

            }
        }

        public virtual void LogWarning(string message)
        {
            var text = $"{DateTime.Now} \n {message.GetType()}\n {message}";


            using (FileStream fstream = new FileStream(@"C:\log\log.txt", FileMode.OpenOrCreate))
            {

                byte[] input = Encoding.Default.GetBytes(text);
                fstream.Write(input, 0, text.Length);

            }
        }

        public virtual void LogError(string message)
        {
            var text = $"{DateTime.Now} \n {message.GetType()}\n {message}";


            using (FileStream fstream = new FileStream(@"C:\log\log.txt", FileMode.OpenOrCreate))
            {

                byte[] input = Encoding.Default.GetBytes(text);
                fstream.Write(input, 0, text.Length);

            }
        }

    }   
}
