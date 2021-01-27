using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Services
{
    class EngineSpec
    {
        public int EngineCapacity;
        public string FuelType;

        public EngineSpec(int capacity, string type)
        {
            EngineCapacity = capacity;
            FuelType = type;
        }
    }
}
