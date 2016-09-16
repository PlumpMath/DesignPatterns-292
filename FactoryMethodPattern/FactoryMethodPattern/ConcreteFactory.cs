using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ConcreteFactory : Factory
    {
        public override File createNewFile(string type, string name)
        {
            if (type == "Text File")
                return new TextFile(name);
            else if (type == "CSV File")
                return new CSVFile(name);
            return null;
        }
    }
}
