using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp.Business
{
    class Car
    {
        public string CarOwner;
        public string PaintColor;
        public int MilesPerGallon;

        public Car(string owner, string color, int mpg)
        {
            CarOwner = owner;
            PaintColor = color;
            MilesPerGallon = mpg;
        }

        public virtual int CalculateFuelForTrip(int tripDistance)
        {
            return tripDistance / MilesPerGallon;
        }

        public virtual void PrintCarDetails()
        {
            Console.WriteLine("---- Car Details ----");
            Console.WriteLine($"Car Owner {CarOwner}");
            Console.WriteLine($"Car colour: {PaintColor}");
            Console.WriteLine($"Gas Milage: {MilesPerGallon}");

        }
    }
}
