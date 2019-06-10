using System;

namespace WakeUp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2019, 10, 6, 10, 49, 30);
            ReminderItem One = new ReminderItem("Wake Up!", date1);
            Console.WriteLine(One.WriteProperties());





            Console.ReadKey();
        }
    }

}
