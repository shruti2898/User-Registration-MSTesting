using UserRegistration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace UserRegistrationUnitTesting
{
    [TestClass]
    public class UnitTesting
    {
         UserRegistrationDetails user = new UserRegistrationDetails();    
         
        [TestMethod]
        public void FirstName()
        {   
            // Arrange 
            bool expected = true;
            string name = "Shruti";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateFirstName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void LastName()
        {
            // Arrange 
            bool expected = true;
            string name = "Verma";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateLastName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Email()
        {
            // Arrange 
            bool expected = true;
            string email = "abc@xyz.com";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MobileNumber()
        {
            // Arrange 
            bool expected = true;
            string mobile = "91 9876543210";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateMobileNumber(mobile);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Password()
        {
            // Arrange 
            bool expected = true;
            string password = "123@xyzA";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
 
}
