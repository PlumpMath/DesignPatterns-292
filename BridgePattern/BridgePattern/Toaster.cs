using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern
{
    public class Toaster : Heater
    {
        public void heat(string food)
        {
            MessageBox.Show("Enjoy your wonderfully toasted " + food);
        }
    }
}
