using System;
namespace RegexProblem
{
	public class UserRegistrationException : Exception
	{
		RegistrationError typeOfError;
        public enum RegistrationError
		{
			INVALID_FNAME,
			INVALID_LNAME,
            INVALID_NAME,
            INVALID_EMAIL,
            INVALID_PHONE_NUMBER,
            INVALID_PASSWORD
            
        }
		public UserRegistrationException(RegistrationError errorType, string message) : base(message)
		{
			this.typeOfError = errorType;
		}
	}
}

