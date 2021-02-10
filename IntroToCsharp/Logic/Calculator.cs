using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Logic
{
    class Calculator
    {
        private void RangeCheck(int num1, int num2)
        {
            if (!(num1 > 0 && num1 < 100 && num2 > 0 && num2 < 100))
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public int CalculateProduct(int num1, int num2)
        {
            RangeCheck(num1, num2);
            
            return num1 * num2;
            
            
            
        }

        public int CalculateSum(int num1, int num2)
        {
            RangeCheck(num1, num2);
            
                return num1 + num2;
           
        }

        public int CalculateRatio(int num1, int num2)
        {
            RangeCheck(num1, num2);
            return num1 / num2;
            
        }
    }
}
