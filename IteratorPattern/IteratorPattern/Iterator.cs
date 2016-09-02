using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class Iterator
    {
        public abstract Team first();
        public abstract Team next();
        public abstract Team currentItem();
        public abstract bool isDone();
    }
}
