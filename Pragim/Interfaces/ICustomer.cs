﻿using System;
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
        void SecondPrint();
    }

    class Customer : ICustomer, ISecondCustomer
    {
        public void Print()
        {
            Console.WriteLine("Interface print method");
        }

        public void SecondPrint()
        {
            Console.WriteLine("Interface print method");
        }
    }
}
