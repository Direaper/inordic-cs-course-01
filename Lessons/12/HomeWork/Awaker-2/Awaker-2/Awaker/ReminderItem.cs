using System;

namespace Awaker
{
  public  class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm
        {
            get
            {
                var TimeNow = DateTime.Now;
                TimeSpan value = TimeNow - AlarmDate; //TimeNow - AlarmDate;
                return value;
            }
        }
        public bool IsOutdated
        {
            get
            {
                return DateTime.Now >= AlarmDate;
            }
        }
        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }
        public virtual void WriteProperties()
        {
            Console.WriteLine($"Type: {GetType()} \n" +
                $"Alarm Date: {AlarmDate} \n" +
                $"Alarm Message: {AlarmMessage} \n" +
                $"Time to Alarm: {TimeToAlarm} \n" +
                $"Is out Date {IsOutdated} \n");
        }
    }
}