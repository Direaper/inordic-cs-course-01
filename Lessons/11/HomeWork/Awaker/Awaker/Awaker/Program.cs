using System;

namespace Awaker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset datetime = DateTimeOffset.Parse("2019-09-07 23:47");
            ReminderItem bud1 = new ReminderItem(datetime, "ALARM");
            bud1.WriteProperties();

            DateTimeOffset datetime2 = DateTimeOffset.Parse("2019-09-07 12:47");
            ReminderItem bud2 = new ReminderItem(datetime, "ALARM");
            bud2.WriteProperties();
        }
    }
}