using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Business
{
    class TripPrinter
    {
        public void PrintTripDetails(Car myCar)
        {
            int[] distances = {5, 15, 20, 25, 40};

            Console.WriteLine($"------ Trip Details for {myCar.CarOwner}------");

            foreach (var distance in distances)
            {
                Console.WriteLine($"{distance} miles requires {myCar.CalculateFuelForTrip(distance)}");
            }
        }
    }
}
