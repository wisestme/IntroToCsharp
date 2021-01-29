using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Business
{
    class FordCar : Car
    {
        public string FordWheelsOption;

        public FordCar(string owner, string color, int mpg, string wheels) : base(owner, color, mpg)
        {
            FordWheelsOption = wheels;
        }
    }
}
