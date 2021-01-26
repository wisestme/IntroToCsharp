using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Services
{
    class NumberBaseConverter
    {
        public void NumberConverter()
        {
            byte b = 138;

            string br = Convert.ToString(b, 2);

            Console.WriteLine($"Original number is {b} and the base 2 representation is {br}");
        }
    }
}
