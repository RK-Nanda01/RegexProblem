using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace RegexProblem
{
	public class RegExpression
    {
	
		public static string REGEX_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public static string REGEX_EMAIL = "^[a-zA-Z][a-zA-Z0-9]*[._+-]?[a-zA-Z0-9]+@[0-9a-z]+.[a-z]+[.]?[a-z]+$";
        public static string REGEX_PHONE_NUMBER = "^91 [1-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).{8,}$";
        public static string REGEX_FIRSTNAME = "^[A-Z][a-zA-Z]{2,}$";
        public static string REGEX_LASTNAME = "^[A-Z][a-zA-Z]{2,}$";

       public Func<string, bool> ValidateName = (name) =>
        {
            if(Regex.IsMatch(name, REGEX_NAME))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.RegistrationError.INVALID_NAME, "First name or Last Name is Invalid");
            }

        };
        public Func<string, bool> ValidateEmail = (email) =>
        {

            if(Regex.IsMatch(email, REGEX_EMAIL))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.RegistrationError.INVALID_EMAIL, "Email is invalid");
            }
        };
        public Func<string, bool> ValidatePhoneNumber = (num) =>
        {
            if (Regex.IsMatch(num, REGEX_PHONE_NUMBER))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.RegistrationError.INVALID_PHONE_NUMBER, "Phone number should of 10 digits and should have country code");
            }

        };
       
        public Func<string, bool> ValidatePassword = (pass) =>
        {
            if (Regex.IsMatch(pass, REGEX_PASSWORD))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.RegistrationError.INVALID_PASSWORD, "Password should be Min 8 chars and should contain atleast One capital, one special char and one numeric");
            }
        };

        public Func<string, bool> ValidateFirstName = (fname) =>
        {
            if (Regex.IsMatch(fname, REGEX_FIRSTNAME))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.RegistrationError.INVALID_FNAME, "First Name should be min 3 chars and should start with Capital");
            }

        };


        public Func<string, bool> ValidateLastName = (lname) =>
        {
            if (Regex.IsMatch(lname, REGEX_LASTNAME))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.RegistrationError.INVALID_LNAME, "Last Name should be min 3 chars and should start with Capital");
            }

        };


    }
}

