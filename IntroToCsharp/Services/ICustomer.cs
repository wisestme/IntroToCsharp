﻿using System;
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

    class Customer : ICustomer
    {
        public void Print()
        {
            Console.WriteLine("good customer");
        }
    }
}
