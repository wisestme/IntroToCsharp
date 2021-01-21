using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Services
{
    public class Comparison
    {
        public void Comparator()
        {
            StringBuilder builder = new StringBuilder("Jesus is coming soon");
            StringBuilder secondBuilder = builder;

            bool areEqual = builder == secondBuilder;
            Console.WriteLine(areEqual);
        }
        
    }
}
