using System;
using System.Security.Cryptography.X509Certificates;
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
            Iteration repeat = new Iteration();
            repeat.ForLoop();
            repeat.ArrayLooping();
            repeat.ArrayForEach();
            repeat.DoWhile();
            repeat.WhileLoop();
            
            Comparison checker = new Comparison();
            checker.Comparator();
            checker.Selector();
            checker.Switcher();
            Console.WriteLine("Learning C# again.");
            AnotherMethod();

            Student firstStudent = new Student
            {
                Id = 100,
                Name = "Chijioke"
            };
            //firstStudent.Passmark = 35;

            Console.WriteLine($"ID = {firstStudent.Id}, and Name = {firstStudent.Name} and Passmark = {firstStudent.Passmark}");

            Customer customer = new Customer();
            ((ICustomer)customer).Print();
            ((ISecondCustomer)customer).Print();
        }
    }
}

    