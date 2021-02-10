using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Logic
{
    class AnotherProduct
    {
        public int itemsInStock;
        public double PricePerItem;

        public int ItemsInStock
        {
            get { return itemsInStock; }

            set
            {
                if (value > 0)
                {
                    itemsInStock = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public double GetTotalValueOfStock()
        {
            return ItemsInStock * PricePerItem;
        }
    }
}
