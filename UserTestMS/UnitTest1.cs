using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTestProblem;

namespace UserTestMS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AAA Methodology

            //Arrange
            string message = "Shr";
            string expected = "valid";

            //Act
            Test testing = new Test(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestLastName()
        {
            //AAA Methodology

            //Arrange
            string message = "Pan";
            string expected = "valid";

            //Act
            Test testing = new Test(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGmail()
        {
            //AAA Methodology

            //Arrange
            string message = "xyz@gmail.com";
            string expected = "valid";

            //Act
            Test testing = new Test(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMobileNo()
        {
            //AAA Methodology

            //Arrange
            string message = "9454977489";
            string expected = "valid";

            //Act
            Test testing = new Test(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestPassword()
        {
            //AAA Methodology

            //Arrange
            string message = "#shreeshPa01";
            string expected = "valid";

            //Act
            Test testing = new Test(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestUpperCase()
        {
            //AAA Methodology

            //Arrange
            string message = "#ShrePa01";
            string expected = "valid";

            //Act
            Test testing = new Test(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestOneNumeric()
        {
            //AAA Methodology

            //Arrange
            string message = "@ShreP01";
            string expected = "valid";

            //Act
            Test testing = new Test(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}