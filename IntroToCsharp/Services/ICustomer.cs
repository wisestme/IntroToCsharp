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
        void ICustomer.Print()
        {
            Console.WriteLine("good customer");
        }

        void ISecondCustomer.Print()
        {
            Console.WriteLine("good second customer");
        }
    }
}
