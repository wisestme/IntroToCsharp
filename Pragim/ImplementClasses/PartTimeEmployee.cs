using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.ImplementClasses
{
    public class PartTimeEmployee : Employee
    {
        private float YearlySalary;

        //public PartTimeEmployee() : base("Inheritance test")
        //{

        //}

        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} Part Time");
        }
    }

    
}
