using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Logic
{
    class Calculator
    {
        private bool RangeCheck(int num1, int num2)
        {
            return num1 > 0 && num1 < 100 && num2 > 0 && num2 < 100;
        }
        public int CalculateProduct(int num1, int num2)
        {
            if (RangeCheck(num1, num2))
            {
                return num1 * num2;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

        public int CalculateSum(int num1, int num2)
        {
            if (RangeCheck(num1, num2))
            {
                return num1 + num2;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int CalculateRatio(int num1, int num2)
        {
            if (RangeCheck(num1, num2))
            {
                return num1 / num2;
            }
            else
            {
                throw  new ArgumentOutOfRangeException();
            }
        }
    }
}
