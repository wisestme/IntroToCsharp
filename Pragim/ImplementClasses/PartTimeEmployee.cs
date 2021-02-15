using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.ImplementClasses
{
    class PartTimeEmployee : Employee
    {
        private float YearlySalary;

        public PartTimeEmployee() : base("Inheritance test")
        {

        }

        public new void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} -PTE");
            
        }
    }

    
}
