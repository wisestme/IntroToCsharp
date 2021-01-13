using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class Customer
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get 
            {
                return $"{LastName} {FirstName}";
            }
            
        }

    }
}
