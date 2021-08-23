using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationMSTest;

namespace UserRegistrationMSTestCases
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Check First Name 
        /// </summary>
        /// <param name="name"></param>
        [TestMethod]  
        [DataRow("Akash")]        
        public void GivenFirstName_CheckIfValid(string name)
        {
            //Arrange
            Validation validation = new Validation();            

            //Act
            bool result = validation.FirstName(name);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("akash")]
        public void GivenFirstName_CheckIfNotValid(string name)
        {
            //Arrange
            Validation validation = new Validation();

            //Act
            bool result = validation.FirstName(name);

            //Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Check Last Name 
        /// </summary>
        /// <param name="name"></param>
        [TestMethod]
        [DataRow("Suchak")]
        public void GivenLastName_CheckIfValid(string name)
        {
            //Arrange
            Validation validation = new Validation();

            //Act
            bool result = validation.LastName(name);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("suchak")]
        public void GivenLastName_CheckIfNotValid(string name)
        {
            //Arrange
            Validation validation = new Validation();

            //Act
            bool result = validation.LastName(name);

            //Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Check Email - ID
        /// </summary>
        /// <param name="email"></param>
        [TestMethod]
        [DataRow("abc@yahoo.com")]        
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenEmail_CheckIfValid(string email)
        {
            //Arrange 
            Validation validation = new Validation();

            //Act
            bool result = validation.Email(email);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("suchak@akash@gmail.com")]     
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void GivenEmail_CheckIfNotValid(string email)
        {
            //Arrange
            Validation validation = new Validation();

            //Act
            bool result = validation.Email(email);

            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Check Mobile
        /// </summary>
        /// <param name="mobile"></param>
        [TestMethod]
        [DataRow("91 9099096400")]
        public void GivenMobile_CheckIfValid(string mobile)
        {
            //Arrange
            Validation validation = new Validation();

            //Act
            bool result = validation.Mobile(mobile);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("9099096400")]
        public void GivenMobile_CheckIfNotValid(string mobile)
        {
            //Arrange
            Validation validation = new Validation();

            //Act
            bool result = validation.Mobile(mobile);

            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Check Password has Minimum 8 characters, 1UpperCase, 1 Special CHaracter
        /// </summary>
        /// <param name="password"></param>
        [TestMethod]
        [DataRow("aHegd9ty#eklci")]
        public void GivenPassword_Min8Chars_1UpperCase_Exact1SpecialChar_CheckIfValid(string password)
        {
            //Arrange
            Validation validation = new Validation();

            //Act
            bool result = validation.Password(password);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("SAbs#Dkfdfd&fej")]
        public void GivenPassword_Min8Chars_1UpperCase_Exact1SpecialChar_CheckIfNotValid(string password)
        {
            //Arrange
            Validation validation = new Validation();

            //Act
            bool result = validation.Password(password);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
