using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.ImplementClasses
{
    class Customer
    {
        private string _firstName;
        private string _lastName;

        public Customer() : this("", "")
        {

        }
        public Customer(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"My name is {this._firstName} {this._lastName}");
        }
    }
}
