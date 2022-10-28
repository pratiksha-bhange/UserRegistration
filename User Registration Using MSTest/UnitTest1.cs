using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace User_Registration_Using_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class UnitTest2
        {
            // test case for First Name
            [TestMethod]
            public void GivenWrongFirstName_ShouldReturnFalse()
            {
                //Arrange
                string firstName = "pratu";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = false;
                //Act
                bool actual = userRegistration.ValidateFirstName(firstName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void GivenCorrectFirstName_ShouldReturnTrue()
            {
                //Arrange
                string firstName = "Pratu";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = true;
                //Act
                bool actual = userRegistration.ValidateFirstName(firstName);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            // test case for last name
            [TestMethod]
            public void GivenWrongLastName_ShouldReturnFalse()
            {
                //Arrange
                string lastName = "bhange";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = false;
                //Act
                bool actual = userRegistration.ValidateLastName(lastName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void GivenCorrectLastName_ShouldReturnTrue()
            {
                //Arrange       
                string lastName = "Bhange";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = true;
                //Act
                bool actual = userRegistration.ValidateLastName(lastName);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            //Test case for Email
            [TestMethod]
            public void GivenWrongEmail_ShouldReturnFalse()
            {
                //Arrange
                string Email = "pratu@gmail.com";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = false;
                //Act
                bool actual = userRegistration.ValidateEmail(Email);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void GivenCorrectEmail_ShouldReturnTrue()
            {
                //Arrange
                string Email = "bhangepratu123@gmail.com";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = true;
                //Act
                bool actual = userRegistration.ValidateEmail(Email);
                //Assert         
                Assert.AreEqual(expected, actual);
            }

            //Test case for Phone Number
            [TestMethod]
            public void GivenWrongPhoneNumber_ShouldReturnFalse()
            {
                //Arrange
                string phoneNumber = "751799595859";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = false;
                //Act
                bool actual = userRegistration.ValidateMobileNoFormat(phoneNumber);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void GivenCorrectPhoneNumber_ShouldReturnTrue()
            {
                //Arrange
                string phoneNumber = "91 9529111295";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = true;
                //Act
                bool actual = userRegistration.ValidateMobileNoFormat(phoneNumber);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            // Test case for Password
            [TestMethod]
            public void GivenWrongPassword_ShouldReturnFalse()
            {
                //Arrange
                string Password = "pass123";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = false;
                //Act
                bool actual = userRegistration.ValidatePassword(Password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void GivenCorrectPassword_ShouldReturnTrue()
            {
                //Arrange
                string Password = "Pass@123";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = true;
                //Act
                bool actual = userRegistration.ValidatePassword(Password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
