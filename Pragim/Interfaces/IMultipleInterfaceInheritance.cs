using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Interfaces
{
    interface IFirstInterface
    {
        void Print();
    }

    interface ISecondInterface
    {
        void SecondPrint();
    }

    class FirstClass : IFirstInterface
    {
        public void Print()
        {
            Console.WriteLine("First class printer");
        }
    }

    class SecondClass : ISecondInterface
    {
        public void SecondPrint()
        {
            Console.WriteLine("Second class printer");
        }
    }

    class ThirdClass : IFirstInterface, ISecondInterface
    {
        FirstClass fc = new FirstClass();
        SecondClass sc = new SecondClass();
        public void Print()
        {
            
            fc.Print();
        }

        public void SecondPrint()
        {
            sc.SecondPrint();
        }
    }
}
