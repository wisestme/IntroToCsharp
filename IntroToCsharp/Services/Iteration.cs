using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Services
{
    class Iteration
    {
        public void ForLoop()
        {
            for (int i = 0; i < 26; i++)
            {
                if(i == 5)
                    continue;
                Console.WriteLine($"Iteration {i}");
            }
        }
    }
}
