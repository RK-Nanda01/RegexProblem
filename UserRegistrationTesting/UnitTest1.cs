namespace UserRegistrationTesting;

using System.Xml.Linq;
using RegexProblem;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow("abcd")]
    [DataRow("ab")]
    public void On_InCorrect_FirstName_ShouldGive_INVALID_FNAME(string input)
    {
        //Arrange
        string expected = "First Name should be min 3 chars and should start with Capital";
        RegExpression user = new RegExpression();
        try
        {
            bool res = user.ValidateFirstName(input);
            Assert.AreEqual(res, expected);
        }

        catch(UserRegistrationException e)
        {
            Assert.AreEqual(e.Message, expected);
        }

    }

    [TestMethod]
    [DataRow("abc")]
    [DataRow("ab")]
    public void On_InCorrect_LastName_ShouldGive_INVALID_LNAME(string input)
    {

        string expected = "Last Name should be min 3 chars and should start with Capital";
        RegExpression user = new RegExpression();
        try
        {
            bool res = user.ValidateLastName(input);
            Assert.AreEqual(res, expected);
        }

        catch (UserRegistrationException e)
        {
            Assert.AreEqual(e.Message, expected);
        }

    }

    [TestMethod]
    [DataRow("1234132467")]
    [DataRow("1234132467")]
    public void On_InCorrect_PhoneNumber_ShouldGive_INVALID_PHONE_NUMBER(string input)
    {
        string expected = "Phone number should of 10 digits and should have country code";
        RegExpression user = new RegExpression();
        try
        {
            bool res = user.ValidatePhoneNumber(input);
            Assert.AreEqual(res, expected);
        }

        catch (UserRegistrationException e)
        {
            Assert.AreEqual(e.Message, expected);
        }

    }
    [TestMethod]
    [DataRow("abc")]
    [DataRow("abcdefhg")]
    [DataRow("abcdefh2G")]
    public void On_InCorrect_Password_Format_ShouldGive_INVALID_PASSWORD(string input)
    {

        string expected = "Password should be Min 8 chars and should contain atleast One capital, one special char and one numeric";
        RegExpression user = new RegExpression();
        try
        {
            bool res = user.ValidatePassword(input);
            Assert.AreEqual(res, expected);
        }

        catch (UserRegistrationException e)
        {
            Assert.AreEqual(e.Message, expected);
        }


    }
    [TestMethod]
    [DataRow("abc123@.com.com")]
    public void On_InCorrect_Email_Format_ShouldGive_INVALID_EMAIL(string input)
    {

        string expected = "Email is invalid";
        RegExpression user = new RegExpression();
        try
        {
            bool res = user.ValidateEmail(input);
            Assert.AreEqual(res, expected);
        }

        catch (UserRegistrationException e)
        {
            Assert.AreEqual(e.Message, expected);
        }


    }

}
