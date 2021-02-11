using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Logic
{
    class ProductCustomType
    {
        public ProductResult CalculateProduct(int num1, int num2)
        {
            return new ProductResult()
            {
                FirstParam = num1,
                SecondParam = num2,
                Result = num1 * num2
            };
            
        }

        public void MyTestMethod(ProductResult PR, int count, bool enableOption)
        {
            Console.WriteLine($"Int value is {count}");
        }
    }
}
