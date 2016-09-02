using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class WinningIterator : Iterator
    {
        ConcreteAggregate agg;
        private int itemNumber;

        public WinningIterator(ConcreteAggregate agg)
        {
            this.agg = agg;
        }

        public override Team first()
        {
            itemNumber = 0;
            while (50 > agg.elements[itemNumber].getWinPercentage())
                itemNumber++;
            return currentItem();
        }

        public override Team next()
        {
            itemNumber++;
            if (!isDone())
            {
                while ((50 > agg.elements[itemNumber].getWinPercentage()))
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
