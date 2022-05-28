using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class Registration
    {
        public string FirstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        
        
        public void checkfirstname(string Firstname)
        {
            Regex Regex = new Regex(FirstName);
            if(Regex.IsMatch(Firstname))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
        }
       
    }
}
