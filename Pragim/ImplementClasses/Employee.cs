using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.ImplementClasses
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public Employee()
        {
            Console.WriteLine("Parent class constructor called");
        }

        public Employee(string message)
        {
            Console.WriteLine(message);
        }
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");

        }
    }
}
