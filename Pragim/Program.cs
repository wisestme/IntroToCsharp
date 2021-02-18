using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pragim.ImplementClasses;
using Pragim.Interfaces;
using Customer = Pragim.Interfaces.Customer;

namespace Pragim
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            ((ICustomer)C1).Print();
            ((ISecondCustomer)C1).Print();

            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (var emp in employees)
            {
                emp.PrintFullName();
            }

            Circle myCircle = new Circle(4);

            float AreaAnswer = myCircle.CalculateCircleArea();
            Console.WriteLine(AreaAnswer);


            //Customer myCustomer = new Customer("Chijioke", "Nwagwu");
            //Customer noParameterCustomer = new Customer();
            

            //myCustomer.PrintFullName();
            //noParameterCustomer.PrintFullName();
        }
    }
}
