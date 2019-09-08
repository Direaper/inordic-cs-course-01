using System;

namespace Awaker
{
    public class ChatReminderItem : ReminderItem
    {
        public ChatReminderItem(DateTimeOffset alarmDate, string alarmMessage, string chatName, string accountName) : base(alarmDate, alarmMessage)
        {
            ChatName = chatName;
            AccountName = accountName;
        }
        public string ChatName { get; set; }
        public string AccountName { get; set; }
        public override void WriteProperties()
        {
            Console.WriteLine($"Type: {GetType()} \n" +
                $"Chatname: {ChatName} \n" +
                $"Account name: {AccountName} \n" +
                $"Alarm Date: {AlarmDate} \n" +
                $"Alarm Message: {AlarmMessage} \n" +
                $"Time to Alarm: {TimeToAlarm} \n" +
                $"Is out Date {IsOutdated} \n");
        }
    }
}