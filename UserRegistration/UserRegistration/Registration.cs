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


        public string checkfirstname(string Firstname)
        {
            Regex Regex = new Regex(FirstName);
            try
            {
                if(Regex.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "First Name cannot be empty");
                }
                else if (Regex.IsMatch(Firstname))
                {
                    return "First Name is valid";
                }
                else
                {
                    return "First Name is Invalid";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "First Name cannot be Null");
            }
        }
        public string checklastname(string Lastname)
        {
            Regex regex = new Regex(LastName);
            try
            {
                if(regex.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Last Name cannot be Empty");
                }
                else if (regex.IsMatch(Lastname))
                {
                    return "Last Name is valid";
                }
                else
                {
                    return "Last Name is Invalid";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Last Name cannot be Null");
            }
            
        }
        public string checkEmail(string EmailID)
        {
            Regex regex = new Regex(EmailAddress);
            try
            {
                if (regex.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Email Id cannot be Empty");
                }
                else if (regex.IsMatch(EmailID))
                {
                    return "Email is valid";
                }
                else
                {
                    return "Email is Invalid";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Email Id cannot be Null");
            }
        }
        public string checkMobile(string MobNumber)
        {
            Regex regex = new Regex(Mobile);
            try
            {
                if (regex.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mobile Number cannot be Empty");
                }
                else if (regex.IsMatch(MobNumber))
                {
                    return "Mobile Number is valid";
                }
                else
                {
                    return "Mobile Number is Invalid";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mobile number cannot be Null");
            }
        }
        public string checkPassword(string password)
        {
            Regex regex = new Regex(Password);
            try
            {
                if (regex.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Password cannot be Empty");
                }
                else if (regex.IsMatch(password))
                {
                    return "Password is valid";
                }
                else
                {
                    return "Password is Invalid";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Password cannot be Null");
            }
        }
        public string SampleEmails(string sample)
        {
            Regex regex = new Regex(SampleEmail);
            try
            {
                if(regex.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Email cannot be Empty");
                }
                else if (regex.IsMatch(sample))
                {
                    return "Email Correct";
                }
                else
                {
                    return "Email is incorrect";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Email cannot be NULL");
            }
        }
    }
}