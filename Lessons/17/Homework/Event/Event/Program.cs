using System;
using System.IO;

namespace Event
{
    
    public class FileWriterWithProgress : EventArgs
    {
        public event EventHandler<FileWriterWithProgress> Work;
 

        public void WriteBytes(string fileName, byte[] data, float percetageToFireEvent)
        {
            for (var i =0; i < data.Length; i++)
            {
                if (i == 10)
                    {
                    //File.AppendAllText("C:\\log\\file.log", "Testing");
                    Console.WriteLine("+10%");
                    Work?.Invoke(this, new FileWriterWithProgress());
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var work = new FileWriterWithProgress();
            work.Work += OnWorkPerform;
            
 
        }
        private static void OnWorkPerform(object sender, FileWriterWithProgress e)
        {
            Console.WriteLine("testing");
        }
    }
}
