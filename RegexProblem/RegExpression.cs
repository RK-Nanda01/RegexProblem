using System;
using System.Text.RegularExpressions;
namespace RegexProblem
{
	public class RegExpression
    {
	
		public static string REGEX_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public bool ValidateName(string name)
		{
			return Regex.IsMatch(name, REGEX_NAME);
		}
	}
}

