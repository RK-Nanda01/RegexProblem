namespace UserRegistrationTesting;

using System.Xml.Linq;
using RegexProblem;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow("Uma", true)]
    [DataRow("Ashok", true)]
    [DataRow("Ad", false)]
    [DataRow("aditya", false)]
    public void On_Correct_FirstNameAndLastName_ShouldGiveTrue(string fname, bool expected)
    {
        //Arrange
        RegExpression user = new RegExpression();

        //Act
        bool resFirstName = user.ValidateFirstName(fname);
        bool resLastName = user.ValidateFirstName(fname);

        //Assert
        Assert.AreEqual(resFirstName, expected);
        Assert.AreEqual(resLastName, expected);

    }

    [TestMethod]
    [DataRow("abc@yahoo.com", true)]
    [DataRow("abc.100@abc.com.au", true)]
    [DataRow("abc@%*.com", false)]
    public void On_Correct_Email_Format_Should_ReturnTrue(string email, bool expected)
    {

        //Arrange
        RegExpression user = new RegExpression();

        //Act
        bool res = user.ValidateEmail(email);
        

        //Assert
        Assert.AreEqual(res, expected);
        

    }

    [TestMethod]
    [DataRow("91 1234132467", true)]
    [DataRow("1234132467", false)]
    [DataRow("1234132467", false)]
    public void On_Correct_PhoneNumer_Format_Should_ReturnTrue(string num, bool expected)
    {

        //Arrange
        RegExpression user = new RegExpression();

        //Act
        bool res = user.ValidatePhoneNumber(num);


        //Assert
        Assert.AreEqual(res, expected);


    }
    [TestMethod]
    [DataRow("abc", false)]
    [DataRow("abcdefhg", false)]
    [DataRow("abcdefh2G", false)]
    [DataRow("abcd@efh2G", true)]
    public void On_Correct_Password_Format_Should_ReturnTrue(string password, bool expected)
    {

        //Arrange
        RegExpression user = new RegExpression();

        //Act
        bool res = user.ValidatePassword(password);


        //Assert
        Assert.AreEqual(res, expected);


    }





}
