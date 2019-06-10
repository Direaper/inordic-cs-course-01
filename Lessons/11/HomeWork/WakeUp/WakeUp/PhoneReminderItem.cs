using System;

namespace WakeUp
{
    public class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber { get; set; }

        public PhoneReminderItem(string phoneNumber, string alarmMessage, DateTimeOffset alarmDate): base(alarmMessage, alarmDate)
        {
            PhoneNumber = phoneNumber;
        }

        public override string WriteProperties()
        {
            return $"Номер:{PhoneNumber}\n Сообщение:{AlarmMessage}\n Дата будильника: {AlarmDate}\n Текущее время: {TimeToAlarm}\n Просрочено ли событие: {IsOutdated}\n Тип:{GetType()}";
        }

    }

   
}
