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
        [DataRow("suchak.akash@gmail.com")]
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
        public void GivenEmail_CheckIfNotValid(string email)
        {
            //Arrange
            Validation validation = new Validation();

            //Act
            bool result = validation.Email(email);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
