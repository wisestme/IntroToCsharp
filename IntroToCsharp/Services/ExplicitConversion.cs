using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Services
{
    class ExplicitConversion
    {
        public void ExplicitConverter()
        {
            checked
            {
                short s = 500;
                byte b = (byte)s;
                Console.WriteLine(b);
            }
           
        }
    }
}
