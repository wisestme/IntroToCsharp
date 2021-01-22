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

        public void ArrayLooping()
        {
            int[] ArrayItems = {1, 2, 3, 4, 5, 6, 7, 8};

            for (int i = 0; i < ArrayItems.Length; i++)
            {
                Console.WriteLine(ArrayItems[i]);
            }
        }
    }
}
