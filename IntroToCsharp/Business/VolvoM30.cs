﻿using System;
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

        public VolvoM30(string ownerName, string paintColor)
        {
            OwnerName = ownerName;
            PaintColor = paintColor;
        }
        public int CalculateFuelForTrip(int TripDistance)
        {
            return TripDistance / GallonsPerMile;
        }

        public void PrintCarDetails()
        {
            Console.WriteLine("------ Car Details -------");
            Console.WriteLine($"Car owner is {OwnerName}");
            Console.WriteLine($"Paint colour of car is {PaintColor}");
            Console.WriteLine($"Car fuel consumption is {GallonsPerMile}");
        }
    }
}