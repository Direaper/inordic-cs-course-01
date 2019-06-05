using System;

namespace TimeToWalk
{
 

    public class ReminderItem
    {
        public  string AlarmMessage; // сообщение соответсвующее будильнику
        public DateTimeOffset AlarmDate; // время до срабатывания будильника, рассчитывается: текущее время - AlarmDate (READONLY)
        public TimeSpan TimeToAlarm; //Время срабатывания будильника
        public bool IsOutdated; // Просрочено ли событие,  truе если TimeToAlarm = 0; false если TimeToAlarm больше или равно 0

        public ReminderItem(string alarmMessage, DateTimeOffset alarmDate)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }

        public string Desk
        {
            get { return $"{AlarmMessage}, {TimeToAlarm}, {AlarmDate}"; }
        }
    

        public void WriteProperties()
        {
           
            
        }

    }
}
