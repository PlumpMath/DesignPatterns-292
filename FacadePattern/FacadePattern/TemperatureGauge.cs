using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class TemperatureGauge
    {
        private string tempSetting = "off";

        public TemperatureGauge()
        {
            
        }

        public string getTemp()
        {
            return tempSetting;
        }

        public void setTemp(string temp)
        {
            tempSetting = temp;
        }
    }
}
