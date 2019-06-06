using System;

namespace WakeUp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2019, 6, 6, 11, 19, 30);
            Budil One = new Budil("Wake Up!", DateTimeOffset.Now, date1);
            One.TimeToAlarm = date1 - DateTimeOffset.Now;
            Console.WriteLine($"{One.TimeToAlarm}");
            while (One.TimeToAlarm == TimeSpan.Zero)
            if (One.TimeToAlarm == TimeSpan.Zero)
            {
                Console.WriteLine($"{One.Speek}, {One.TimeToAlarm}");
            }
                   
            Console.ReadKey();
        }
    }

    public class Budil
    {
        public string AlarmDate;
        public DateTimeOffset DaTiOf;
        public DateTime DaTi;
        public TimeSpan TimeToAlarm;

        public Budil(string alarmDate, DateTimeOffset daTiOf, DateTime daTi)
        {
            AlarmDate = alarmDate;
            DaTiOf = daTiOf;
            DaTi = daTi;
        }

        public string Speek
        {
            get { return $"Сообщение:{AlarmDate}"; }
        }

 

    }

}
