using System;
using System.Text.RegularExpressions;
namespace RegexProblem
{
	public class RegExpression
    {
	
		public static string REGEX_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public static string REGEX_EMAIL = "^[a-zA-Z][a-zA-Z0-9]*[._+-]?[a-zA-Z0-9]+@[0-9a-z]+.[a-z]+[.]?[a-z]+$";
        public static string REGEX_PHONE_NUMBER = "^91 [1-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        
        public bool ValidateName(string name)
		{
			return Regex.IsMatch(name, REGEX_NAME);
		}
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidatePhoneNumber(string num)
        {
            return Regex.IsMatch(num, REGEX_PHONE_NUMBER);
        }
        public bool ValidatePassword(string pass)
        {
            return Regex.IsMatch(pass, REGEX_PASSWORD);
        }
    }
}

