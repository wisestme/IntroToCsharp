using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Business
{
    class VolvoM30
    {
        public string Type;
        public string OwnerName;
        public string PaintColor;
        public int GallonsPerMile = 30;
        public int NumberOfDoors;
        public DateTime AssembledDate;

        public int CalculateFuelForTrip(int TripDistance)
        {
            return TripDistance / GallonsPerMile;
        }
    }
}
