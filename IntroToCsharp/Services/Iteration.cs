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

        int[] ArrayItems = { 1, 2, 3, 4, 5, 6, 7, 8 };
        public void ArrayLooping()
        {
            

            for (int i = 0; i < ArrayItems.Length; i++)
            {
                Console.WriteLine(ArrayItems[i]);
            }
        }

        public void ArrayForEach()
        {
            foreach (var item in ArrayItems)
            {
                if(item == 3)
                    break;
                Console.WriteLine(item);
            }
        }

        public void DoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine(ArrayItems[i]);
                i++;
            } while (i < 5);
        }

        public void WhileLoop()
        {
            int i = 0;
            while (i <= 7)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
