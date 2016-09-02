using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class RankedIterator : Iterator
    {
        ConcreteAggregate agg;
        private int itemNumber;
        private int temp;

        public RankedIterator(ConcreteAggregate agg)
        {
            this.agg = agg;
        }

        public override Team first()
        {
            itemNumber = 0;
            while (!(int.TryParse(agg.elements[itemNumber].getRank(), out temp)))
                itemNumber++;
            return currentItem();
        }

        public override Team next()
        {
            itemNumber++;
            if (!isDone())
            {
                while (!(int.TryParse(agg.elements[itemNumber].getRank(), out temp)))
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
