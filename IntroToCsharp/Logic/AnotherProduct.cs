using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Logic
{
    class AnotherProduct
    {
        public int ItemsInStock;
        public double PricePerItem;

        public double GetTotalValueOfStock()
        {
            return ItemsInStock * PricePerItem;
        }
    }
}
