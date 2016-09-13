using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Alarm
    {
        bool isAlarmOn = false;
        private double alarmTime;

        public Alarm()
        {
        }

        public void turnOff()
        {
            isAlarmOn = false;
        }

        public void setAlarm(double time)
        {
            isAlarmOn = true;
            alarmTime = time;
        }

        public bool isOn()
        {
            return isAlarmOn;
        }

        public double getTime()
        {
            return alarmTime;
        }
    }
}
