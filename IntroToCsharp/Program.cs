﻿using System;
using System.Security.Cryptography.X509Certificates;
using IntroToCsharp.Business;
using IntroToCsharp.Services;


namespace IntroToCsharp
{    
    public class Student
    {
        private int _id;
        private string _name;
        private int _passmark = 35;

        //public void SetPassmark(int Passmark)
        //{
        //    if(Passmark != 35)
        //    {
        //        throw new Exception("Passmark must be equal to 35");
        //    }
        //    this._passmark = Passmark;
        //}

        public string City { get; set; }

        public string Email { get; set; }
        public int Passmark
        {
            get
            {
            return this._passmark;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null");
                }
                this._name = value;
            }

            get
            {
                return this._name;
            }
            
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id must be greater than zero");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
            
        }

        
    }

    
    public class Program
    {
        static void AnotherMethod()
        {
            Console.WriteLine("Learning C# in another method.");
        }
        static void Main()
        {
            TripPrinter printTrip = new TripPrinter();
           

            VolvoW30 myW30 = new VolvoW30("Nathan", "blue", 20, "Himax");
            myW30.PrintCarDetails();

            printTrip.PrintTripDetails(myW30);

            FordWisest myFordWisest = new FordWisest("Wisest", "green", 25, "Alloy reams");
            myFordWisest.PrintCarDetails();

            VolvoCar wisestVolvo = new VolvoCar("Chijioke", "red", 20, "wisest atmos");
            wisestVolvo.PrintCarDetails();
            int fuelRequired = wisestVolvo.CalculateFuelForTrip(300);
            Console.WriteLine($"Fuel required is {fuelRequired} gallons");

            //EngineSpec wisestEngine = new EngineSpec(250, "Six rings");

            //VolvoM30 wisestCar = new VolvoM30("Chijioke", "white", wisestEngine);
            //VolvoM30 yourCar = new VolvoM30("Onah", "black", wisestEngine);

            //Console.WriteLine(wisestCar.OwnerName);
            //Console.WriteLine(yourCar.OwnerName);
            //Console.WriteLine(yourCar.Engine.EngineCapacity);

            //NumberBaseConverter NBC = new NumberBaseConverter();
            //NBC.NumberConverter();
            //ArithmeticOperators ao = new ArithmeticOperators();
            //ao.ArithmeticOperations();
            //ExplicitConversion EC = new ExplicitConversion();
            //EC.ExplicitConverter();
            //Iteration repeat = new Iteration();
            //repeat.ForLoop();
            //repeat.ArrayLooping();
            //repeat.ArrayForEach();
            //repeat.DoWhile();
            //repeat.WhileLoop();
            
            //Comparison checker = new Comparison();
            //checker.Comparator();
            //checker.Selector();
            //checker.Switcher();
            //Console.WriteLine("Learning C# again.");
            //AnotherMethod();

            //Student firstStudent = new Student
            //{
            //    Id = 100,
            //    Name = "Chijioke"
            //};
            //firstStudent.Passmark = 35;

            //Console.WriteLine($"ID = {firstStudent.Id}, and Name = {firstStudent.Name} and Passmark = {firstStudent.Passmark}");

            //Customer customer = new Customer();
            //((ICustomer)customer).Print();
            //((ISecondCustomer)customer).Print();
        }
    }
}

    