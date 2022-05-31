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
        public string Password = "^(?=.*?[A-Za-z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-.+=_]).{8,}$";

        public string checkfirstname(string Firstname)
        {
            Regex Regex = new Regex(FirstName);
            if(Regex.IsMatch(Firstname))
            {
                return "First Name is valid";
            }
            else
            {
                return "First Name is Invalid";
            }
        }
        public string checklastname(string Lastname)
        {
            Regex regex = new Regex(LastName);
            if (regex.IsMatch(Lastname))
            {
                return "Last Name is valid";
            }
            else
            {
                return "Last Name is Invalid";
            }
        }
        public string checkEmail(string EmailID)
        {
            Regex regex = new Regex(EmailAddress);
            if (regex.IsMatch(EmailID))
            {
                return "Email is valid";
            }
            else
            {
                return "Email is Invalid";
            }
        }
        public string checkMobile(string MobNumber)
        {
            Regex regex = new Regex(Mobile);
            if (regex.IsMatch(MobNumber))
            {
                return "Mobile Number is valid";
            }
            else
            {
                return "Mobile Number is Invalid";
            }
        }
        public string checkPassword(string password)
        {
            Regex regex = new Regex(Password);
            if (regex.IsMatch(password))
            {
                return "Password is valid";
            }
            else
            {
                return "Password is Invalid";
            }
        }
    }
}
