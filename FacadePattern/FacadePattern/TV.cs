using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class TV
    {
        private bool tvOn = false;
        private string input = "cable";

        public TV()
        {

        }

        public void setInput(string input)
        {
            this.input = input;
        }

        public string getInput()
        {
            return input;
        }

        public void turnOn()
        {
            tvOn = true;
        }

        public void turnOff()
        {
            tvOn = false;
        }

        public bool isOn()
        {
            return tvOn;
        }
    }
}
