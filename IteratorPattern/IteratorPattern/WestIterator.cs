using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class WestIterator : Iterator
    {
        ConcreteAggregate agg;
        private int itemNumber;

        public WestIterator(ConcreteAggregate agg) {
            this.agg = agg;
        }

        public override Team first()
        {
            itemNumber = 0;
            while (!("Big Ten West" == agg.elements[itemNumber].getDivision()))
                itemNumber++;
            return currentItem();
        }

        public override Team next()
        {
            itemNumber++;
            if (!isDone())
            {
                while (!("Big Ten West" == agg.elements[itemNumber].getDivision()))
                {
                    itemNumber++;
                    if (isDone())
                        return null;
                }
            }
            return currentItem();
        }

        public override bool isDone()
        {
            return itemNumber == agg.elements.Count;
        }

        public override Team currentItem()
        {
            if (isDone())
                return null;
            return agg.elements[itemNumber];
        }
    }
}
