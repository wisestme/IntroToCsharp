using System;


namespace IntroToCsharp
{    
    public class Student
    {
        private int _id;
        private string _name;
        private int _passmark;

        public void SetPassmark(int Passmark)
        {
            if(Passmark != 35)
            {
                throw new Exception("Passmark must be equal to 35");
            }
            this._passmark = Passmark;
        }

        public int GetPassmark()
        {
            return this._passmark;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null");
            }
            this._name = Name;
        }

        public string GetName()
        {
            return this._name;
        }
        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student Id must be greater than zero");
            }
            this._id = Id;
        }

        public int  GetId()
        {
            return this._id;
        }
    }

    
    class Program
    {
        
        static void AnotherMethod()
        {
            Console.WriteLine("Learning C# in another method.");
        }
        static void Main()
        {
            Console.WriteLine("Learning C# again.");
            AnotherMethod();

            Student firstStudent = new Student();
            firstStudent.SetId(100);
            firstStudent.SetName("Chijioke");
            firstStudent.SetPassmark(35);

            Console.WriteLine($"ID = {firstStudent.GetId()}, and Name = {firstStudent.GetName()} and Passmark = {firstStudent.GetPassmark()}");
        }
    }
}

    