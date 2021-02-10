using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Business
{
    class Goods
    {
        public int itemsInStock = 300;
        public string productName;
        Supplier productSupplier;

        public Goods(string pName, string sName)
        {
            productName = pName;
            productSupplier = new Supplier(sName);
        }

        public void ReadModifyQuantity()
        {
            int ReadValue = itemsInStock;
            Console.WriteLine($"Current stock {ReadValue}");
            itemsInStock = 20;
            Console.WriteLine($"Current stock {itemsInStock}");
        }
    }
}
