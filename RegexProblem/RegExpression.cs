using System;
using System.Text.RegularExpressions;
namespace RegexProblem
{
	public class RegExpression
    {
	
		public static string REGEX_FIRSTNAME = "^[A-Z][a-zA-Z]{2,}$";
		public bool ValidateFirstName(string fname)
		{
			return Regex.IsMatch(fname, REGEX_FIRSTNAME);
		}
	}
}

