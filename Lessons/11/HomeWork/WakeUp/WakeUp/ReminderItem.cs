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

        public string WriteProperties()
        {
             return $"Сообщение:{AlarmMessage}, Дата будильника: {AlarmDate}, Текущее время: {TimeToAlarm}, Просрочено ли событие: {IsOutdated}"; 
        }

 

    }

}
