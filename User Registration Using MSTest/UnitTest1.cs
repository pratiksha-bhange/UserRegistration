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
                //
                string phoneNumber = "7517995958";
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
                string phoneNumber = "91 7517995958";
                UserRegistration1 userRegistration = new UserRegistration1();
                bool expected = true;
                //Act
                bool actual = userRegistration.ValidateMobileNoFormat(phoneNumber);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            // UC5,UC6,UC7,UC8 - Test case for Password
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


            // UC9-Test case for multiple Emails
            [TestMethod]
            public void GivenParameterizedTest_ToCheckValidMultipleEntries_ReturnEntryIsSucessful()
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                var result = registrationCheck.CheckMultipleEntriesOfEmail("abc@yahoo.com", "abc-100@yahoo.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc@1.com");
                Assert.AreEqual(result, "Entry is successful");
            }

            [TestMethod]
            public void GivenParameterizedTest_ToCheckInvalidMultipleEntries_ReturnEntryIsNotSucessful()
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                var result = registrationCheck.CheckMultipleEntriesOfEmail("abc", "abc123@gmail.a", "abc@.com.my", "abc123@.com", "abc123@.com.com");
                Assert.AreEqual(result, "Entry is not successful");
            }
        }
        // UC12 - Test case to take Custom Exception for Invalid First Name.
        [TestMethod]
        [DataRow("pratu")]
        public void GivenFirstName_WhenInvalid_ThenShouldThrow_InvalidFirstNameException(string firstName)
        {
            try
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                registrationCheck.CheckFirstName(firstName);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Invalid First Name Format", ex.Message);
            }
        }

        // UC12 - Test case to take Custom Exception for Invalid Last Name.
        [TestMethod]
        [DataRow("bhange")]
        public void GivenLastName_WhenInvalid_ThenShouldThrow_InvalidLastNameException(string lastName)
        {
            try
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                registrationCheck.CheckLastName(lastName);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Last Name Format", exception.Message);
            }
        }

        // UC12 - Test case to take Custom Exception for Invalid Email.
        [TestMethod]
        [DataRow("abc@.com.my")]
        public void GivenEmail_WhenInvalid_ThenShouldThrow_InvalidEmailException(string email)
        {
            try
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                registrationCheck.CheckEmail(email);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Email Format", exception.Message);
            }
        }

        // UC12 - Test case to take Custom Exception for Invalid Phone Number.
        [TestMethod]
        [DataRow("7517995958")]
        public void GivenMobileFormat_WhenInvalid_ThenShouldThrow_InvalidMobileFormatException(string phoneNumber)
        {
            try
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                registrationCheck.CheckMobile(phoneNumber);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Mobile Number Format", exception.Message);
            }
        }

        // UC12 - Test case to take Custom Exception for Invalid Password.
        [TestMethod]
        [DataRow("pass@123")]
        public void GivenPasswordFormat_WhenInvalid_ThenShouldThrow_InvalidPasswordFormatException(string Password)
        {
            try
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                registrationCheck.CheckPassword(Password);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Password Format", exception.Message);
            }
        }
    }
}
    

