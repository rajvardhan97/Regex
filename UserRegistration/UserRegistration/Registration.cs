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


        public Func<string, string> checkfirstname = (FirstName) =>
        {
            Regex regex = new Regex(FirstName);
            try
            {
                if (FirstName.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "First Name cannot be Empty");
                }
                else if (regex.IsMatch(FirstName))
                {
                    return "First Name is valid";
                }
                else
                {
                    return "Invalid First Name";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "First Name cannot be Null");
            }
        };

        public Func<string, string> checklastname = (LastName) =>
        {
            Regex regex = new Regex(LastName);
            try
            {
                if (LastName.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Last Name cannot be Empty");
                }
                if (regex.IsMatch(LastName))
                {
                    return "Last Name is valid";
                }
                else
                {
                    return "Last Name is Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Last Name cannot be Null");
            }
        };

        public Func<string, string> checkEmail = (EmailAddres) =>
        {
            Regex regex = new Regex(EmailAddres);
            try
            {
                if (regex.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Email cannot be Empty");
                }
                else if (regex.IsMatch(EmailAddres))
                {
                    return "Email ID is valid";
                }
                else
                {
                    return "Email ID is Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Email cannot be Null");
            }
        };

        public Func<string, string> checkMobile = (Mobile) =>
        {
            Regex regex = new Regex(Mobile);
            try
            {
                if (regex.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mobile Number cannot be Empty");
                }
                if (regex.IsMatch(Mobile))
                {
                    return "Mobile Number is Valid";
                }
                else
                {
                    return "Mobile Number is Invalid";
                }

            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mobile Number cannot be Null");
            }
        };

        public Func<string, string> checkPassword = (Password) =>
        {
            Regex regex = new Regex(Password);
            try
            {
                if (Password.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Password cannot be Empty");
                }
                else if (regex.IsMatch(Password))
                {
                    return "Password is Valid";
                }
                else
                {
                    return "Password is Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Password cannot be Null");
            }
        };

        public Func<string, string> SampleEmails = (SampleEmail) =>
        {
            Regex regex = new Regex(SampleEmail);
            try
            {
                if (regex.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Email cannot be Empty");
                }
                else if (regex.IsMatch(SampleEmail))
                {
                    return "Email is Correct";
                }
                else
                {
                    return "Email is incorrect";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Email cannot be NULL");
            }
        };
    }
}