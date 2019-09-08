using System;

namespace Awaker
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DateTimeOffset datetime = DateTimeOffset.Parse("2019-09-07 23:47");
            ReminderItem bud1 = new ReminderItem(datetime, "ALARM");
            bud1.WriteProperties(); */

            ReminderItem[] Reminders = new ReminderItem[3];
            Reminders[0] = new ReminderItem(DateTimeOffset.Parse("2019-09-07 23:47"), "ALARM!");
            Reminders[1] = new PhoneReminderItem(DateTimeOffset.Parse("2019-09-10 13:00"), "please, wake up", "00000000");
            Reminders[2] = new ChatReminderItem(DateTimeOffset.Parse("2019-09-12 01:00"), "WAKE UP!!", "Мои кореша", "Толя-Лысый");

            foreach (var i in Reminders)
            {
                i.WriteProperties();
            }

        }
    }
}