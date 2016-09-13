using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class RoomRemote
    {
        public Alarm alarm = new Alarm();
        public Lights bedroomLights = new Lights();
        public Lights livingRoomLights = new Lights();
        public TemperatureGauge temperatureGauge = new TemperatureGauge();
        public TV tv = new TV();

        public RoomRemote()
        {

        }

        public void wakeUp()
        {
            alarm.turnOff();
            bedroomLights.turnOn();
            temperatureGauge.setTemp("Off");
        }

        public void leaveRoom()
        {
            temperatureGauge.setTemp("Off");
            bedroomLights.turnOff();
            livingRoomLights.turnOff();
            tv.turnOff();
        }

        public void watchTV()
        {
            livingRoomLights.turnOn();
            bedroomLights.turnOff();
            temperatureGauge.setTemp("Off");
            tv.turnOn();
            tv.setInput("Cable");
        }

        public void study()
        {
            livingRoomLights.turnOff();
            bedroomLights.turnOn();
            temperatureGauge.setTemp("Low Warm");
            tv.turnOff();
        }

        public void watchMovie()
        {
            livingRoomLights.turnOff();
            bedroomLights.turnOff();
            temperatureGauge.setTemp("Off");
            tv.turnOn();
            tv.setInput("Xbox");
        }

        public void goToBed(double time)
        {
            livingRoomLights.turnOff();
            bedroomLights.turnOff();
            alarm.setAlarm(time);
            temperatureGauge.setTemp("Cold");
            tv.turnOff();
        }
    }
}
