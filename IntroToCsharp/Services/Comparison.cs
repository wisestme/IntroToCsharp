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

        public void Selector()
        {
            int x = 100;
            if (x == 100)
            {
                Console.WriteLine("This is the city called centenary");
            }
            else
            {
                Console.WriteLine("I don't know what you are talking about");
            }
        }
        
    }
}
