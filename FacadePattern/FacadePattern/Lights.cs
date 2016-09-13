using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Lights
    {
        private bool lightsOn = false;
        public Lights()
        {

        }

        public bool areOn()
        {
            return lightsOn;
        }

        public void turnOn()
        {
            lightsOn = true;
        }

        public void turnOff()
        {
            lightsOn = false;
        }
    }
}
