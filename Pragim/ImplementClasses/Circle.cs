using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.ImplementClasses
{
    class Circle
    {
        private int _radius;
        static float PI = 3.142F;

        public Circle(int Radius)
        {
            this._radius = Radius;
        }

        public float CalculateCircleArea()
        {
            return PI * this._radius * this._radius;
        }
    }
}
