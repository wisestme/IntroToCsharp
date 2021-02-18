using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Interfaces
{
    interface ICustomer
    {
        void Print();
    }

    interface ISecondCustomer
    {
        void Print();
    }


    class Customer : ICustomer, ISecondCustomer
    {
        void ICustomer.Print()
        {
            Console.WriteLine("Interface print method");
        }

        void ISecondCustomer.Print()
        {
            Console.WriteLine("Second interface print method");
        }

        public void SecondPrint()
        {
            Console.WriteLine("Interface print method");
        }
    }
}
