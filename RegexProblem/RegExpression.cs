using System;
using System.Text.RegularExpressions;
namespace RegexProblem
{
	public class RegExpression
    {
	
		public static string REGEX_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public static string REGEX_EMAIL = "^[a-zA-Z][a-zA-Z0-9]*[._+-]?[a-zA-Z0-9]+@[0-9a-z]+.[a-z]+[.]?[a-z]+$";
        public bool ValidateName(string name)
		{
			return Regex.IsMatch(name, REGEX_NAME);
		}
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}

