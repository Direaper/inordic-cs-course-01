using System;

namespace WakeUp
{
    public class ChatReminderItem : ReminderItem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }

        public ChatReminderItem(string chatname, string accountname, string alarmMessage, DateTimeOffset alarmDate) : base(alarmMessage, alarmDate)
        {
            ChatName = chatname;
            AccountName = accountname;
        }
        public override string WriteProperties()
        {
            return $"Название чата: {ChatName}\n Аккаунт: {AccountName}\n Сообщение:{AlarmMessage}\n Дата будильника: {AlarmDate}\n Текущее время: {TimeToAlarm}\n Просрочено ли событие: {IsOutdated}\n Тип:{GetType()}";
        }

    }
}
