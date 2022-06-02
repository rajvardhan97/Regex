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
            Console.WriteLine(registration.checkfirstname(fName));

            Console.WriteLine("Enter the Last Name");
            string lName = Console.ReadLine();
            Console.WriteLine(registration.checklastname(lName));

            Console.WriteLine("Enter the Email Address");
            string Email = Console.ReadLine();
            Console.WriteLine(registration.checkEmail(Email));

            Console.WriteLine("Enter Mobile Number");
            string mobile = Console.ReadLine();
            Console.WriteLine(registration.checkMobile(mobile));

            Console.WriteLine("Enter the Password");
            string password = Console.ReadLine();
            Console.WriteLine(registration.checkPassword(password));

            Console.WriteLine("Enter Sample Email");
            string mail = Console.ReadLine();
            Console.WriteLine(registration.SampleEmails(mail));
        }
    }
}