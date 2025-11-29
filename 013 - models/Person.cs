using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013___models
{
    internal class  Person
    {
        public int Id { get; set; }//it's a property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }


        public string GetFullName()
        {
            return ($"Your name is {FirstName} {LastName}");
        }

        public bool IsValidAge()
        {
            return Age > 10 && Age < 100;
        }
    }
}
