using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Registration registration = new Registration();
            Console.WriteLine("Enter the First Name");
            string fName = Console.ReadLine();
            registration.checkfirstname(fName);
        }
    }
}