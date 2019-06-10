using System;

namespace WakeUp
{
    public class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm { get { return AlarmDate - DateTime.Now; } set { } }
        public bool IsOutdated
        {
            get
            {
                if (TimeToAlarm == TimeSpan.Zero)
                {
                   return true;
                }
                else
                {
                    return false;
                }
            }
            set { } }


        public ReminderItem(string alarmMessage, DateTimeOffset alarmDate)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }

        public virtual string WriteProperties()
        {
             return $"Сообщение:{AlarmMessage}\n Дата будильника: {AlarmDate}\n Текущее время: {TimeToAlarm}\n Просрочено ли событие: {IsOutdated}\n Тип:{GetType()}"; 
        }
    }
}
