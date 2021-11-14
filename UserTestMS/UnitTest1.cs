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
    }
}
