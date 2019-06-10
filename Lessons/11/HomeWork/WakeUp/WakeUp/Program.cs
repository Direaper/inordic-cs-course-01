using System;

namespace WakeUp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2019, 10, 6, 10, 49, 30);
            DateTime date2 = new DateTime(2018, 12, 2, 15, 59, 3);
            ReminderItem One = new ReminderItem("Wake Up!", date1);
            Console.WriteLine($"{One.WriteProperties()}\n");

            ChatReminderItem User1 = new ChatReminderItem("Chat", "User1", "Wake up Neo!", date1);
            Console.WriteLine($"{User1.WriteProperties()}\n");

            PhoneReminderItem Phone1 = new PhoneReminderItem("892132445", "Hello!", date2);
            Console.WriteLine($"{Phone1.WriteProperties()}\n");

            Console.ReadKey();
        }
    }

}
