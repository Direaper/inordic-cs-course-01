using System;

namespace Awaker
{
    public class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber { get; set; }
        public PhoneReminderItem(DateTimeOffset alarmDate, string alarmMessage, string phoneNumber) : base(alarmDate, alarmMessage)
        {
            PhoneNumber = phoneNumber;
        }

        public override void WriteProperties()
        {
            Console.WriteLine($"Type: {GetType()} \n" +
                $"Phone Number {PhoneNumber} \n" +
                $"Alarm Date: {AlarmDate} \n" +
                $"Alarm Message: {AlarmMessage} \n" +
                $"Time to Alarm: {TimeToAlarm} \n" +
                $"Is out Date {IsOutdated} \n");
        }
    }
}