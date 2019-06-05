using System;

namespace TimeToWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset dt = DateTimeOffset.Now;
            ReminderItem a2 = new ReminderItem("WAKE UP", dt);
            Console.WriteLine($"{a2.AlarmMessage}, { dt}");
        }
    }
}
