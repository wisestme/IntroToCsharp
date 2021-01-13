using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Services
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
        public void Print()
        {
            Console.WriteLine("good customer");
        }
    }
}
