using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class Factory
    {
        public void createFile(string type, string name, string text)
        {
            File file = createNewFile(type, name);
            file.createFile();
            file.writeToFile(text);
        }
        public abstract File createNewFile(string type, string name);
    }
}
