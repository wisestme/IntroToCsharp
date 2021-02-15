using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.ImplementClasses
{
    public class FullTimeEmployee : Employee
    {
        private float YearlySalary;

        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} Full Time");

        }
    }
}
