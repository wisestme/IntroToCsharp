using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.ImplementClasses
{
    public class Employee
    {
        public string FirstName = "Chijioke";
        public string LastName = "Nwagwu";
        public string Email;

        //public Employee()
        //{
        //    Console.WriteLine("Parent class constructor called");
        //}

        //public Employee(string message)
        //{
        //    Console.WriteLine(message);
        //}
        public virtual void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");

        }
    }
}
