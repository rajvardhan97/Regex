using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Registration
    {
        public string FirstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public string LastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public string EmailAddress = "^[a-zA-Z0-9_\\-\\.]+[@][a-z]+[\\.]([a-z]{2,3})([\\.]?[a-z]*)$";
        public string Mobile = "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public string Password = "^(?=.*[A-Za-z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-.+=_]).{8,}$";
        public string SampleEmail = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";

        public void checkfirstname(string Firstname)
        {
            Regex Regex = new Regex(FirstName);
            if (Regex.IsMatch(Firstname))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
        }
        public void checklastname(string Lastname)
        {
            Regex regex = new Regex(LastName);
            if (regex.IsMatch(Lastname))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Last Name is Invalid");
            }
        }
        public void checkEmail(string EmailID)
        {
            Regex regex = new Regex(EmailAddress);
            if (regex.IsMatch(EmailID))
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Email is Invalid");
            }
        }
        public void checkMobile(string MobNumber)
        {
            Regex regex = new Regex(Mobile);
            if (regex.IsMatch(MobNumber))
            {
                Console.WriteLine("Mobile Number is valid");
            }
            else
            {
                Console.WriteLine("Mobile Number is Invalid");
            }
        }
        public void checkPassword(string password)
        {
            Regex regex = new Regex(Password);
            if (regex.IsMatch(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is Invalid");
            }
        }
        public void SampleEmails(string sample)
        {
            Regex regex = new Regex(SampleEmail);
            if(regex.IsMatch(sample))
            {
                Console.WriteLine("Email Correct");
            }
            else
            {
                Console.WriteLine("Email is incorrect");
            }
        }
    }
}
