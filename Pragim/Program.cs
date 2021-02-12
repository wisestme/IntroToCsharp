using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pragim.ImplementClasses;

namespace Pragim
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer myCustomer = new Customer("Chijioke", "Nwagwu");
            Customer noParameterCustomer = new Customer();
            

            myCustomer.PrintFullName();
            noParameterCustomer.PrintFullName();
        }
    }
}
