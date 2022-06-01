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
            Console.Write(registration.checkfirstname(fName) + "\n");

            Console.WriteLine("Enter the Last Name");
            string lName = Console.ReadLine();
            Console.Write(registration.checklastname(lName) + "\n");

            Console.WriteLine("Enter the Email Address");
            string Email = Console.ReadLine();
            Console.Write(registration.checkEmail(Email) + "\n");

            Console.WriteLine("Enter Mobile Number");
            string mobile = Console.ReadLine();
            Console.Write(registration.checkMobile(mobile) + "\n");

            Console.WriteLine("Enter the Password");
            string password = Console.ReadLine();
            Console.Write(registration.checkPassword(password) + "\n");
        }
    }
}